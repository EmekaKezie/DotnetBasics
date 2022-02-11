using System;
using System.Collections.Generic;
using System.Text;

namespace RefreshMemory
{
    class CustomExceptionHandling : ApplicationException
    {
        public CustomExceptionHandling(string error) : base(error)
        {

        }
    }

    class ExceptionDemo
    {
        public static void Demo()
        {
            int a, b;
            Console.WriteLine("Enter 2 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());


            Calc(a, b);
        }

        public static void Calc(int a, int b)
        {
            if(a < 0 || b < 0)
            {
                throw new CustomExceptionHandling("Zero is and invalid number . . ");
            }
            else
            {
                Console.WriteLine(a + b);
            }
        }
    }

}
