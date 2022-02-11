using System;
using System.Collections.Generic;
using System.Text;

namespace RefreshMemory
{
    class Constructors
    {
        public Constructors()
        {
            DemoOne();
        }

        public Constructors(string name)
        {
            DemoTwo(name);
        }

        private void DemoOne()
        {
            Console.WriteLine("Constructors: Demo 1");
        }

        private void DemoTwo(string name)
        {
            Console.WriteLine($"Constructors: {name}");
        }
    }

}
