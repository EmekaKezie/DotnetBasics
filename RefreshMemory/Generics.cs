using System;
using System.Collections.Generic;
using System.Text;

namespace RefreshMemory
{
    class Generics
    {
        public void DemoOne<T>(T value)
        {
            Console.WriteLine(value);
        }

        public void Addition<A, B>(A ValueOne, B ValueTwo)
        {
            Console.WriteLine($"{ValueOne}, {ValueTwo}");
        }

       
    }

    class GenericClass<TId, TName>
    {
        public TId Id { get; set; }
        public TName Name { get; set; }

    }


    class GenericClassTwo<T>
    {
        public T Item { get; set; }
    }


    class GenericModelOne
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductAmount { get; set; }
        public bool ProductSold { get; set; }
    }

    class GenericModelTwo
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DeptsEnum EmployeeDept { get; set; }
        public bool ProductSold { get; set; }

    }

    enum DeptsEnum
    {
        ADMIN,
        ACCOUNT,

    }


    
}
