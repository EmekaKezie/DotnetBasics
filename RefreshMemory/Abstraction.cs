using System;
using System.Collections.Generic;
using System.Text;

namespace RefreshMemory
{
    abstract class Abstraction
    {
        public Abstraction()
        {
            MethodOne();
        }

        public abstract void Email();

        protected abstract void Name();


        private void MethodOne()
        {
            Console.WriteLine("Abstract class constructor - METHOD ONE");
        }


        sealed class User
        {

        }
    }



    class Lokesh : Abstraction
    {
        public override void Email()
        {
            Console.WriteLine("Email as lokesh@gmail.com");
        }

        protected override void Name()
        {
            Console.WriteLine("Name as Rahul . . .");
        }
    }



    abstract class Animal
    {
        public abstract void Name();
        public abstract void Type();
    }


    class Lion: Animal, IData
    {
        public override void Name()
        {
            Console.WriteLine("Name is Lion  . . .");
        }

        public override void Type()
        {
            Console.WriteLine("It's a wild animal  . . .");
        }

        public void Words()
        {
            throw new NotImplementedException();
        }

        public void Home()
        {
            throw new NotImplementedException();
        }
    }


    class Crocodile : Animal
    {
        public override void Name()
        {
            Console.WriteLine("Name is Crocodile  . . .");
        }

        public override void Type()
        {
            Console.WriteLine("It's a water animal  . . .");
        }

    }
}
