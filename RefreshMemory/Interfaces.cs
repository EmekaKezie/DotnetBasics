using System;
using System.Collections.Generic;
using System.Text;

namespace RefreshMemory
{
    class Interfaces
    {
    }

    interface IData
    {
        void Home();
        void Words();
    }

    class Bolton : IData
    {
        public void Home()
        {
            Console.WriteLine("Dreadfort");
        }

        public void Words()
        {
            Console.WriteLine("Our blades are sharp");
        }
    }

    class Mormont : IData
    {
        public void Home()
        {
            Console.WriteLine("Bear Islan");
        }

        public void Words()
        {
            Console.WriteLine("Here we stand");
        }
    }
}
