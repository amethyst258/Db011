using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace database2.Extention
{
    public static class EnumExtention
    {
        public static string GetDisplayName(this Enum enumvalue)
        {
            return enumvalue.GetType().GetMember(enumvalue.ToString()).First()
                .GetCustomAttribute<DisplayAttribute>().GetName();
        }
    }
}
