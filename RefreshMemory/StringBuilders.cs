using System;
using System.Collections.Generic;
using System.Text;

namespace RefreshMemory
{
    class StringBuilders
    {
        public static void Demo()
        {
            string data = "This is my string builder";
            StringBuilder sb = new StringBuilder(data);
            sb.Append(". And I love it");
            sb.Remove(5, 10);

            Console.WriteLine(sb);
        }
    }
}
