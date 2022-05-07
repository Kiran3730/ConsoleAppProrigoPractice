using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    public class Book
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Aname { get; set; }
        public int Price { get; set; }


        public static void Display()
        {
            Book[] list = new Book[5]
                {
            new Book{Id=1,Name="Java",Aname="Kalidas",Price=200},
            new Book{Id=2,Name="SQL",Aname="Ramdas",Price=300},
            new Book{Id=3,Name="Cpp",Aname="James",Price=400},
            new Book{Id=4,Name="Kotlin",Aname="Gosling",Price=500},
            new Book{Id=5,Name="React",Aname="John",Price=50},
                };

            foreach (Book bb in list)
            {
                for (; bb.Price < 500;)
                //if( bb.Price < 500)
                {
                        Console.WriteLine(+bb.Id + " " + bb.Name + " " + bb.Aname + " " + bb.Price);
                    break;
                    }
                }


            }
        }
    }




   
       
    




