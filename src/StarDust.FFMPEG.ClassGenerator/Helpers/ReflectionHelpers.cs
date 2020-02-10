using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StarDust.FFMPEG.ClassGenerator
{
    internal static class ReflectionHelpers
    {

        public static IDictionary<string,T> GetDisplayValues<T>(Type type, BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Static)
        {           
            return type
                .GetFields(bindingFlags)
                 .Where(f => f.FieldType == typeof(T))
                .ToDictionary(
                x => x.GetCustomAttribute<DisplayAttribute>().Name, 
                x => (T)x.GetValue(null)
                );
        }

    }
}
