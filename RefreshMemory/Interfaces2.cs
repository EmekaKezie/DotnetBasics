using System;
using System.Collections.Generic;
using System.Text;

namespace RefreshMemory
{
    class Interfaces2
    {
    }

    interface IOne
    {
        void Lords();
    }

    interface ITwo
    {
        void Region();
    }

    class Highgarden : IOne, ITwo
    {
        public void Lords()
        {
            Console.WriteLine("Tyrell");
        }

        public void Region()
        {
            Console.WriteLine("The Reach");
        }
    }
}
