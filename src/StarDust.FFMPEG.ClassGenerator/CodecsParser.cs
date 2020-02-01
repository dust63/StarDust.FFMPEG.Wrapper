using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StarDust.FFMPEG.ClassGenerator
{
    internal static class CodecsParser
    {


        internal static List<CodecDescriptor> Parse(string codecsFilePath)
        {
            // Read the file and display it line by line.  
            using (StreamReader sr = File.OpenText(codecsFilePath))
            {
                var result = new List<CodecDescriptor>();
                string line = String.Empty;
                var counter = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    counter++;
                    if (counter < 11)
                        continue;
                    string field1 = line.Substring(1, 7).Trim();
                    string field2 = line.Substring(8, 21).Trim();
                    string field3 = line.Substring(29, line.Length-29).Trim();
                    result.Add(CodecDescriptor.Parse(field1, field2, field3));
                }
                return result;
            }
           
        }



    }


}
