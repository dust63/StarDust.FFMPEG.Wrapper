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
    public class FFProcessWrapper
    {
        public EventHandler<FFMpegOutputEventArgs> OutputDataReceived;

        public delegate void OutputDataReceivedEventHandler(SynchronizationContext context);

        public EventHandler<FFMpegOutputEventArgs> ErrorDataReceived;

        public delegate void ErrorDataReceivedEventHandler(SynchronizationContext context);

        
        public string FFMPEGPath { get; private set; }
           

        public Process FFMpegProcess { get; private set; }

        public bool IsRunning { get; private set; }
        public StreamWriter InputFFmpeg { get; private set; }

        private CancellationTokenSource CancellationToken { get; set; }

        public FFProcessWrapper(string ffmpegPath)
        {
            if (File.Exists(ffmpegPath))
                FFMPEGPath = ffmpegPath;
            else throw new
                    FileNotFoundException("Can't localize ffmpeg.exe", ffmpegPath);
        }


        public async void Test()
        {
            await Start("-version");
        }


        public async Task Start(string arguments, CancellationTokenSource tokenSource = default)
        {
            if (FFMpegProcess != null)
                throw new InvalidOperationException("The ffmpeg process is already launched");

            if (tokenSource == default(CancellationTokenSource))
                tokenSource = new CancellationTokenSource();

            CancellationToken = tokenSource;        


            FFMpegProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = FFMPEGPath,
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
                await Task.WhenAny(
                  ReadStream(FFMpegProcess.StandardOutput, OnOutputReceived, CancellationToken.Token),
                  ReadStream(FFMpegProcess.StandardError, OnErrorReceived, CancellationToken.Token),
                  FFMpegProcess.WaitForExitAsync(CancellationToken.Token)
                  );
            }
            finally
            {
                CancellationToken = null;
                DisposingFFmpegProcess();
            }
        }


        private void DisposingFFmpegProcess()
        {
            FFMpegProcess?.Dispose();
            FFMpegProcess = null;
        }


        private Task OnErrorReceived(string obj)
        {
            var e = new FFMpegOutputEventArgs(obj);
            return ErrorDataReceived.InvokeAsync(this, e);
        }

        private Task OnOutputReceived(string obj)
        {
            var e = new FFMpegOutputEventArgs(obj);
            return OutputDataReceived.InvokeAsync(this, e);
        }

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

        public async Task Stop()
        {
            if (FFMpegProcess == null)
                return;

            //Try to exit ffmpeg with the command q
            FFMpegProcess.StandardInput?.Write("q");

            //Wait 2sec for the process to exited
            await Task.WhenAny(Task.Delay(2000), Task.Run(async ()=>
            {
                while(!(FFMpegProcess?.HasExited ?? true))
                {
                    await Task.Delay(100);
                }
            }));

            //If process is disposed do return
            if (FFMpegProcess == null)
                return;

            //Try to cancel
            CancellationToken.Cancel();
            await Task.Delay(500);

            //Kill the process if already present
            if (FFMpegProcess != null && !FFMpegProcess.HasExited)
                Kill();
        }


        public void Kill()
        {
            FFMpegProcess?.Kill();
            DisposingFFmpegProcess();
        }


    }

    public class FFMpegOutputEventArgs : DeferredEventArgs
    {

        public FFMpegOutputEventArgs(string data)
        {
            Data = data;
        }
        public string Data { get; }
    }
}
