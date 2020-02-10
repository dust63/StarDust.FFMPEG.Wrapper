using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarDust.FFMPEG.Wrapper
{
    public class DShowDeviceList
    {
        const string DeviceListCommand = "-hide_banner -list_devices true -f dshow -i null";


        public List<string> AudioDevices { get; private set; }

        public List<string> VideoDevices { get; private set; }
            

        public async Task<DShowDeviceList> GetDevices(IFFMPEGProcessWrapper wrapper)
        {
            
            var output = await wrapper.StartAndGetResult(DeviceListCommand, null);
            var values = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x=> x.IndexOf("]") > -1 && x.StartsWith("[dshow", StringComparison.OrdinalIgnoreCase))
                .Select(x=>  x.Substring(x.IndexOf("]") + 1).Trim())
                .ToList();

            VideoDevices = values
                .Skip(1)
                .Take(values.IndexOf(values.First(x => x.EndsWith("DirectShow audio devices")))-1)
                .Where(x=> x.StartsWith("\""))
                .Select(x=> x.Replace("\"", string.Empty))
                .ToList();

            AudioDevices = values
               .Skip(values.IndexOf(values.First(x => x.EndsWith("DirectShow audio devices"))))
               .Take(values.Count - values.IndexOf(values.First(x => x.EndsWith("DirectShow audio devices"))))
               .Where(x => x.StartsWith("\""))
               .Select(x => x.Replace("\"", string.Empty))
               .ToList();

            return this;
        }

    }
}
