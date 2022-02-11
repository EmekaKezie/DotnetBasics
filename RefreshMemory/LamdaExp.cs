using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefreshMemory
{
    class LamdaExp
    {
        public void LamdaDemo()
        {
            List<LinqDemoEmploy> empList = new List<LinqDemoEmploy>
            {
                new LinqDemoEmploy{EmpNo=1, Name="Jon Doe",  Dept="Accounts",  Basic=400000},
                new LinqDemoEmploy{EmpNo=2, Name="Jane Doe",  Dept="HR",  Basic=500000},
                new LinqDemoEmploy{EmpNo=3, Name="Mike Joe",  Dept="IT",  Basic=450000},
                new LinqDemoEmploy{EmpNo=4, Name="Michelle Joe",  Dept="Accounts",  Basic=550000},
                new LinqDemoEmploy{EmpNo=5, Name="Tom Jon",  Dept="HR",  Basic=400000},
                new LinqDemoEmploy{EmpNo=6, Name="Rita Mike",  Dept="IT",  Basic=450000},
                new LinqDemoEmploy{EmpNo=7, Name="Steve Tom",  Dept="Accounts",  Basic=500000},
            };



            List<LinqDemoDept> deptList = new List<LinqDemoDept>();

            var result1 = empList.Select(x => x.Name);
            foreach (var a in result1)
            {
                Console.WriteLine($"Name:{a}");

            }


            Console.WriteLine("\n");
            var result2 = empList.Select(x => new
            {
                x.Name,
                x.EmpNo
            });
            foreach(var a in result2)
            {
                Console.WriteLine($"ID:{a.EmpNo}, Name:{a.Name}");
            }


            Console.WriteLine("\n");
            var result3 = empList.Where(x => x.Basic > 400000).Select(x => x.Name);
            foreach(var a in result3)
            {
                Console.WriteLine($"Name:{a}");
            }
        }
    }
}
