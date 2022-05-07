using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment
{
    class Student1
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string addr { get; set; }
        public int marks { get; set; }

        /*public override string ToString()
        {
            return $"stud Id :{Id} stud name :{Name} stud addr:{addr} marks :{marks}";
        }*/
        public static void stud()
        {


            Student1[] studlist = new Student1[3]
              {
                  new Student1 { Id = 1, Name = "sagar", addr = "pune", marks = 77 },
                  new Student1 { Id = 2, Name = "harish", addr = "sangamner", marks = 78 },
                  new Student1 { Id = 3, Name = "kiran", addr = "nashik", marks = 79 },
              };

            foreach(Student1 s in studlist)
            {
                Console.WriteLine("id :"+s.Id+"  "+"Name :"+s.Name+" "+"Addres :"+" "+s.addr+" "+"Marks :"+s.marks);
            }
        }
       


    }


}

