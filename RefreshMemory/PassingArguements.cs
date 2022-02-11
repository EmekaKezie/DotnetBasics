using System;
using System.Collections.Generic;
using System.Text;

namespace RefreshMemory
{
    class PassingArguements
    {   
        public static int ProcessNumber(ref int num)
        {
            return num;
        }

        public static void Show(params string[] names)
        {
            foreach(string i in names)
            {
                Console.WriteLine(i);
            }
        }
    }
}
