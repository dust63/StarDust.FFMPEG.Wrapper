using DeferredEvents;
using StarDust.FFMPEG.Wrapper.Helpers;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StarDust.FFMPEG.Wrapper
{
    ///<inheritdoc/>
    public class FFMPEGProcessWrapper : IFFMPEGProcessWrapper
    {
        #region -- Fields --

        private CancellationTokenSource _cancellationToken;

        #endregion

        #region -- Events --

        /// <inheritdoc/>   
        public event EventHandler<FFMpegOutputEventArgs> OutputDataReceived;

        /// <inheritdoc/>   
        public event EventHandler<FFMpegOutputEventArgs> ErrorDataReceived;

        #endregion

        #region -- Properties --

        
        /// <inheritdoc/>   
        public string FFMPEGPath { get; set; }

        /// <inheritdoc/>   
        public Process FFMpegProcess { get; private set; }

        /// <inheritdoc/>   
        public bool IsRunning { get; private set; }

        #endregion

        #region -- Ctors --

        public FFMPEGProcessWrapper()
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="ffmpegPath"></param>
        public FFMPEGProcessWrapper(string ffmpegPath)
        {
            if (File.Exists(ffmpegPath))
                FFMPEGPath = ffmpegPath;
            else throw new
                    FileNotFoundException("Can't localize ffmpeg.exe", ffmpegPath);
        }

        #endregion

        #region -- Public methods
        public async Task<string> StartAndGetResult(string arguments, CancellationTokenSource tokenSource)
        {
            var sb = new StringBuilder();
           var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = FFMPEGPath ?? "ffmpeg.exe",
                    Arguments = arguments,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,                   
                    StandardErrorEncoding = Encoding.UTF8,
                    StandardOutputEncoding = Encoding.UTF8
                }
            };
            process.Start();
            sb.Append(process.StandardOutput.ReadToEnd());
            sb.AppendLine(process.StandardError.ReadToEnd());          
            await process.WaitForExitAsync(tokenSource?.Token ?? default(CancellationToken));

            return sb.ToString();
        }


        /// <inheritdoc/>   
        public async Task Start(string arguments, CancellationTokenSource tokenSource = default)
        {
            if (FFMpegProcess != null)
                throw new InvalidOperationException("The ffmpeg process is already launched");

            if (tokenSource == default(CancellationTokenSource))
                tokenSource = new CancellationTokenSource();

            _cancellationToken = tokenSource;


            FFMpegProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = FFMPEGPath ?? "ffmpeg.exe",
                    Arguments = arguments,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    RedirectStandardInput = true,
                    StandardErrorEncoding = Encoding.UTF8,
                    StandardOutputEncoding = Encoding.UTF8
                }
            };

            try
            {
                FFMpegProcess.Start();
                IsRunning = true;
                await Task.WhenAny(
                  ReadStream(FFMpegProcess.StandardOutput, OnOutputReceived, _cancellationToken.Token),
                  ReadStream(FFMpegProcess.StandardError, OnErrorReceived, _cancellationToken.Token),
                  FFMpegProcess.WaitForExitAsync(_cancellationToken.Token)
                  );
            }
            finally
            {
                _cancellationToken = null;
                DisposingFFmpegProcess();
            }
        }
        /// <inheritdoc/>   
        public async Task Stop()
        {
            if (FFMpegProcess == null)
                return;

            //Try to exit ffmpeg with the command q
            FFMpegProcess.StandardInput?.Write("q");

            //Wait 2sec for the process to exited
            await Task.WhenAny(Task.Delay(2000), Task.Run(async () =>
            {
                while (!(FFMpegProcess?.HasExited ?? true))
                {
                    await Task.Delay(100);
                }
            }));

            //If process is disposed do return
            if (FFMpegProcess == null)
                return;

            //Try to cancel
            _cancellationToken.Cancel();
            await Task.Delay(500);

            //Kill the process if already present
            if (FFMpegProcess != null && !FFMpegProcess.HasExited)
                Kill();
        }
        /// <inheritdoc/>   
        public void Kill()
        {
            FFMpegProcess?.Kill();
            DisposingFFmpegProcess();
        }

        #endregion

        #region -- Private methods


        /// <summary>
        /// Disposing ffmpeg process and set variable
        /// </summary>
        private void DisposingFFmpegProcess()
        {
            FFMpegProcess?.Dispose();
            FFMpegProcess = null;
            IsRunning = false;
        }


        /// <summary>
        /// When we received error from ffmpeg console
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private Task OnErrorReceived(string data)
        {
            var e = new FFMpegOutputEventArgs(data);
            return ErrorDataReceived.InvokeAsync(this, e);
        }

        /// <summary>
        /// When we receive an error from output console
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private Task OnOutputReceived(string data)
        {
            var e = new FFMpegOutputEventArgs(data);
            return OutputDataReceived.InvokeAsync(this, e);
        }


        /// <summary>
        /// use to listen console of ffmpeg
        /// </summary>
        /// <param name="textReader"></param>
        /// <param name="callback"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        private async static Task ReadStream(TextReader textReader, Func<string, Task> callback, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                var line = await textReader.ReadLineAsync();
                if (line == null)
                    break;

                await callback(line);
            }
        }

        #endregion


    }
}
