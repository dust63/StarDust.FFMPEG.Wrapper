using System;
using System.Collections.Generic;
using System.Text;

namespace StarDust.FFMPEG.ClassGenerator
{
    public class CodecDescriptor
    {

        public bool Video { get; set;}

        public bool Audio { get; set; }

        public bool Subtitle { get; set; }

        public bool Encoding { get; set; }

        public bool Decoding { get; set; }


        public string Name { get; set; }


        public string Description { get; set; }

        public static CodecDescriptor Parse(string data, string name, string description)
        {
            return new CodecDescriptor
            {
                Video = data.Contains("V"),
                Audio = data.Contains("A"),
                Subtitle = data.Contains("S"),
                Encoding = data.Contains("E"),
                Decoding = data.Contains("D"),
                Name = name,
                Description = description
            };
        }
    }
}
