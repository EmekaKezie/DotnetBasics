using System;
using System.Collections.Generic;
using System.Text;

namespace RefreshMemory
{
    class Arrays
    {
        public void Demo()
        {
            int[] a = new int[] { 12, 66, 23, 88, 24 };

            //method one
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("\n");

            //method two
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            //string array
            string[] names = new string[] {
                "Emeka", "Amaka", "Emena", "Ebuka"
            };

            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

        }
    }
}
