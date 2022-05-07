using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    public class Course
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Fee { get; set; }


        public static void Display()
        {
            Course[] list = new Course[5] {

            new Course { Id = 1, Name = "Java", Fee = 2500 },
            new Course { Id = 2, Name = "Csharp", Fee = 40000 },
            new Course { Id = 3, Name = "MYSQL", Fee = 80000 },
            new Course { Id = 4, Name = "Angular", Fee = 35000 },
            new Course { Id = 5, Name = "React", Fee = 50000 },
        };
            foreach (Course c in list)
            {
                Console.WriteLine(c.Id+" "+c.Name+" "+c.Fee);
            }
        }
       
    }
 }

   
