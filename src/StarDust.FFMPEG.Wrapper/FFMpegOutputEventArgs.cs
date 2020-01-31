using DeferredEvents;

namespace StarDust.FFMPEG.Wrapper
{
    public class FFMpegOutputEventArgs : DeferredEventArgs
    {

        public FFMpegOutputEventArgs(string data)
        {
            Data = data;
        }
        public string Data { get; }
    }
}
