using System;
using System.Collections;

namespace RefreshMemory
{
    class Program
    {

        int empno;
        string name;
        double basic;

        public override string ToString()
        {
            return $"Employ No.: {empno}, Name: {name}, Basic: {basic}";
        }

        static Program()
        {
            Console.WriteLine("Program Static Constrauct");
        }

        Program()
        {

        }



        static void Main(string[] args)
        {
            //Arrays
            Arrays obj = new Arrays();
            obj.Demo();


            Console.WriteLine("\n");


            //Passing Parameters
            int num = 20;
            Console.WriteLine(PassingArguements.ProcessNumber(ref num));
            string[] names = new string[] { "Ladosh", "Lodash" };
            PassingArguements.Show("Lodak", "Ludish");


            Console.WriteLine("\n");


            //Constructors
            Console.WriteLine(" ========== CONSTRUCTORS =============");
            Program empoly = new Program
            {
                empno = 1,
                name = "Ladosh",
                basic = 800000
            };
            Console.WriteLine(empoly);


            Console.WriteLine("\n");


            //Constructors
            Console.WriteLine(" ========== CONSTRUCTORS =============");
            Constructors constructors1 = new Constructors();
            Constructors constructors2 = new Constructors("Demo 2");


            Console.WriteLine("\n");


            //Inheritance
            Console.WriteLine(" ========== INHERITANCE =============");
            InheritanceB inh = new InheritanceB();
            inh.DemoTwo();

            StudentClass studentClass = new StudentClass("Chinonso", "Okeke", 24);
            Console.WriteLine(studentClass);


            Console.WriteLine("\n");


            //ExtensionMethod
            Console.WriteLine(" ========== EXTENSION METHODS =============");
            string exMethStr = "This is and Extension Method";
            string exMethStr_Caps = exMethStr.ToCapslock();
            Console.WriteLine(exMethStr_Caps);


            Console.WriteLine("\n");


            //String Builders
            Console.WriteLine(" ========== STRING BUILDERS =============");
            StringBuilders.Demo();


            Console.WriteLine("\n");


            //String Builders
            Console.WriteLine(" ========== CUSTOM EXCEPTION HANDLING =============");
            ExceptionDemo exceptionDemo = new ExceptionDemo();
            ExceptionDemo.Demo();


            Console.WriteLine("\n");


            //Absctraction
            Console.WriteLine(" ========== ABSCTRACTION =============");
            new Lokesh();

            Animal[] animalArr = new Animal[]
            {
                new Lion(),
                new Crocodile()
            };

            foreach (Animal a in animalArr)
            {
                a.Name();
                a.Type();
            }


            Console.WriteLine("\n");


            Console.WriteLine(" ========== INTERFACES =============");
            IData[] idataArr = new IData[] { new Bolton(), new Mormont() };
            foreach (IData a in idataArr)
            {
                a.Home();
                a.Words();
            }

            Highgarden highgarden = new Highgarden();
            highgarden.Lords();
            highgarden.Region();



            Console.WriteLine("\n");


            Console.WriteLine(" ========== PROPERTIES =============");
            Properties properties = new Properties();
            properties.SetEmptId(1);
            properties.SetEmpName("John Doe");
            properties.SetEmpRole("Sales Executive");

            Console.WriteLine($"Employee Name: {properties.GetEmpId()}");
            Console.WriteLine($"Employee Role: {properties.GetEmpRole()}");



            Console.WriteLine("\n");


            Console.WriteLine(" ========== GENERIC METHODS =============");
            Generics generics = new Generics();
            generics.DemoOne<int>(3);

            GenericClass<int, string> genericClass = new GenericClass<int, string>
            {
                Id = 1,
                Name = "Emeka"
            };
            Console.WriteLine($"Id: {genericClass.Id}, Name: {genericClass.Name}");



            Console.WriteLine("\n");


            Console.WriteLine(" ========== DLL =============");
            MakeDLL.DllDemo dlldemoobj = new MakeDLL.DllDemo();
            Console.WriteLine(dlldemoobj.Sum(2, 6));
            Console.WriteLine(dlldemoobj.Sub(2, 6));



            Console.WriteLine("\n");


            Console.WriteLine(" ========== LINQ =============");
            LinqDemo linqDemo = new LinqDemo();
            linqDemo.Emp();


            Console.WriteLine("\n");


            Console.WriteLine(" ========== LAMDA =============");
            LamdaExp lamdaExp = new LamdaExp();
            lamdaExp.LamdaDemo();
        }
    }

}
