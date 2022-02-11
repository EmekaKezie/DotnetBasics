using System;
using System.Collections.Generic;
using System.Text;

namespace RefreshMemory
{
    class Boxing
    {
        public static void Demo()
        {
            int x = 12;
            double y = 12.5;
            string name = "Lodash";


            /*boxing*/
            object ob1 = x;
            object ob2 = y;
            object ob3 = name;


            /*unboxing*/
            int x1 = (Int32)ob1;
            double y1 = (Double)ob2;
            string name2 = (String)ob3;
        }
    }
}
