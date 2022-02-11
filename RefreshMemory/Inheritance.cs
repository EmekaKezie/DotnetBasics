using System;
using System.Collections.Generic;
using System.Text;

namespace RefreshMemory
{
    class Inheritance
    {
        protected void Demo(string name)
        {
            Console.WriteLine($"First Inhearitance: {name}");
        }
    }

    class InheritanceB : Inheritance
    {
        public void DemoTwo()
        {
            Console.WriteLine("Second Inheritance");
            base.Demo("Emeka");
        }
    }



    class Student
    {
        private string firstname, lastname;
        private int age;

        public Student(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Student First Name: {firstname}, Student Last Name: {lastname}, Student Age {24}";
        }
    }

    class StudentClass : Student
    {
        public StudentClass(string firstname, string lastname, int age) : base(firstname, lastname, age)
        {

        }
    }
}
