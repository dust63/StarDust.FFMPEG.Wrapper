using System;
using System.Threading;
using System.Threading.Tasks;

namespace StarDust.FFMPEG.Wrapper
{
    /// <summary>
    /// A way to use ffmpeg. Create a process that wrapp ffmpeg
    /// </summary>
    public interface IFFMPEGProcessWrapper
    {
        /// <summary>
        /// When we output error from FFMPEG
        /// </summary>
        event EventHandler<FFMpegOutputEventArgs> OutputDataReceived;

        /// <summary>
        /// When we received error from FFMPEG
        /// </summary>
        event EventHandler<FFMpegOutputEventArgs> ErrorDataReceived;

        /// <summary>
        /// Indicate where ffmpeg is located on
        /// </summary>
        string FFMPEGPath { get; set; }

        /// <summary>
        /// Indicate if ffmpeg is currently running
        /// </summary>
        bool IsRunning { get; }

        /// <summary>
        /// Kill the runngin process
        /// </summary>
        void Kill();

        /// <summary>
        /// Start ffmpeg with arguments
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="tokenSource"></param>
        /// <returns></returns>
        Task Start(string arguments, CancellationTokenSource tokenSource = null);

        /// <summary>
        /// Stop properly ffmpeg, if not kill it
        /// </summary>
        /// <returns></returns>
        Task Stop();
    }
}