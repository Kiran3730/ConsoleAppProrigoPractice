using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Training_Programs
{
     class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Per { get; set; }
        public string Branch { get; set; }


        public static void studentdetails()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student { RollNo= 1, Name = "sagar", Per= 78, Branch = "chemistry" },
                new Student { RollNo= 2, Name = "harish", Per= 70, Branch = "biology" },
                new Student { RollNo= 3, Name = "pranav", Per= 60, Branch = "physics" },
                new Student { RollNo= 4, Name = "manish", Per= 55, Branch = "math" },
                new Student { RollNo= 5, Name = "saurabh", Per= 35, Branch = "english" },
                new Student { RollNo= 6, Name = "tushar", Per= 87, Branch = "geography" },
                new Student { RollNo= 7, Name = "satyam", Per= 98, Branch = "history" },
                new Student { RollNo= 8, Name = "krishna", Per= 66, Branch = "physics" },
                new Student { RollNo= 9, Name = "sagar", Per= 48, Branch = "english" },


            };

            /*var result = from s in studentList
                         orderby s.Name
                         select s;*/

            /*var result = from s in studentList
                         where s.Branch.Contains("english")
                         select s;*/

            /*var result = from s in studentList
                         where s.Per > 55
                         select s;*/


            /*var result = from s in studentList
                         orderby s.Per  descending
                          select s;*/

            /*var result = from s in studentList
                         where s.Name.StartsWith('s') || s.Name.StartsWith('k')
                         select s;*/

            var result = from s in studentList
                         where s.Name.Contains("sagar") && s.Per > 55
                         select s;



            foreach (Student item in result)
            {
                Console.WriteLine($"{item.Name} {item.Per} ");
            }
        }


    }
}
