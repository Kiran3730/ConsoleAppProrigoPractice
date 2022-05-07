using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Training_Programs
{
     class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }
       


        public static void studentdetails()
        {
            List<Courses> courseList = new List<Courses>()
            {
                new Courses { Id=1,Name="C#",Fees=4500},
                new Courses { Id=2,Name="JAVA",Fees=3000},
                new Courses { Id=3,Name="HTML",Fees=2800},
                new Courses { Id=4,Name="C",Fees=4000},
                new Courses { Id=5,Name="C++",Fees=4800},
                new Courses { Id=6,Name="SQL",Fees=5000},
                new Courses { Id=7,Name="PYTHON",Fees=4300},
                new Courses { Id=8,Name="AUTOCAD",Fees=3500},
                new Courses { Id=9,Name="PHP",Fees=3800},
                new Courses { Id=10,Name="DOT NET",Fees=4200},
            };
           // 1.display course whose fees is greater than 4000
            var result1 = from c in courseList
                          where c.Fees > 4500
                          orderby c.Fees
                          select c;

            /*2.display all element assending order by their name
            var result1 = from c in courseList
                          orderby c.Name
                          select c;*/

            /*3.display all element Fees betwwen than 3500 to 4500
               var result1 = from c in courseList
                             where c.Fees > 3500 && c.Fees < 4500
                             orderby c.Fees
                            select c;*/

            //4.display course  belong to java
            /* var result1 = from c in courseList
                           where c.Name.Contains("JAVA")
                           orderby c.Name
                           select c;*/

            //5.display course fees assending order
            /*var result1 = from c in courseList
                          orderby c.Fees
                          select c;*/


            foreach (Courses c in result1)
            {
                Console.WriteLine($"{c.Id} {c.Name} {c.Fees}");
            }
        }


    }
}

