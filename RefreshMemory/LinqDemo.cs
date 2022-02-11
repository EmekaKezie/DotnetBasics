using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefreshMemory
{
    class LinqDemo
    {
        public void Emp()
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


            List<LinqDemoDept> deptList = new List<LinqDemoDept>
            {
                new LinqDemoDept{DeptNo=1, Name="Accounts", DeptHead="Jon"},
                new LinqDemoDept{DeptNo=2, Name="HR", DeptHead="Jane"},
                new LinqDemoDept{DeptNo=3, Name="IT", DeptHead="Mike"},
            };

            foreach (var a in empList)
            {
                Console.WriteLine($"ID:{a.EmpNo}, Name:{a.Name}");
            }


            Console.WriteLine("\n");
            var result1 = from em in empList select em;
            foreach (var a in result1)
            {
                Console.WriteLine($"Employee ID:{a.EmpNo}, Employee Name:{a.Name}");
            }


            Console.WriteLine("\n");
            foreach (var a in empList.Where(list => list.Name.Equals("Jon Doe")))
            {
                Console.WriteLine($"Employee ID:{a.EmpNo}, Employee Name:{a.Name}");
            }


            Console.WriteLine("\n");
            var result2 = from a in empList where a.Name == "Jon Doe" select a;
            foreach (var a in result2)
            {
                Console.WriteLine($"Employee ID:{a.EmpNo}, Employee Name:{a.Name}");
            }


            Console.WriteLine("\n");
            var result3 = from b in empList
                          where b.EmpNo < 3
                          orderby b.Basic descending
                          select b;
            foreach (var a in result3)
            {
                Console.WriteLine($"Employee ID:{a.EmpNo}, Employee Name:{a.Name}, Basic:{a.Basic}");
            }


            Console.WriteLine("\n");
            var result4 = from c in empList
                          select new
                          {
                              c.Name,
                              c.Basic,
                          };
            foreach(var a in result4)
            {
                Console.WriteLine($"Basic:{a.Basic} - {a.Name}");
            }


            Console.WriteLine("\n");
            var result5 = from emp in empList
                          join dept in deptList on emp.Dept equals dept.Name
                          select new
                          {
                             emp.Name,
                             dept.DeptHead
                          };
            foreach(var a in result5)
            {
                Console.WriteLine($"Employee Name:{a.Name}, Department Head:{a.DeptHead}");
            }

        }



    }

    class LinqDemoEmploy
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public int Basic { get; set; }

    }

    class LinqDemoDept
    {
        public int DeptNo { get; set; }
        public string Name { get; set; }
        public string DeptHead { get; set; }

    }

}
