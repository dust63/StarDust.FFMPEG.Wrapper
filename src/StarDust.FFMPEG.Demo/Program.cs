using StarDust.FFMPEG.Wrapper;
using System;
using System.Threading.Tasks;

namespace StarDust.FFMPEG.Demo
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Lauching ffmpeg");
            var ffmpegPath = @"C:\ProgramData\chocolatey\lib\ffmpeg\tools\ffmpeg\bin\ffmpeg.exe";
            var wrapper = new FFMPEGProcessWrapper(ffmpegPath);
            wrapper.ErrorDataReceived += (s, e) => Console.Error.WriteLine(e.Data);
            wrapper.OutputDataReceived += (s, e) => Console.WriteLine(e.Data);
            Task.Run(async ()=> await wrapper.Start("-f gdigrab -framerate 30 -i desktop -y D:\\output.mkv"));
            Console.WriteLine($"FFmpeg is ruuning on process: {wrapper?.FFMpegProcess?.Id}");
            Console.ReadKey();
            wrapper.Stop().GetAwaiter().GetResult();
            Console.WriteLine("ffmpeg stopped");
            Console.WriteLine("Tap any key to exit...");
            Console.ReadKey();
            Console.WriteLine("End of the demo");          
        }
    }
}
