using System;
using System.Collections.Generic;
using System.Text;

namespace RefreshMemory
{
    static class ExtensionMethod
    {
        public static string ToCapslock(this string str)
        {
            string caps = str.ToUpper();
            return caps;
        }
    }
}
