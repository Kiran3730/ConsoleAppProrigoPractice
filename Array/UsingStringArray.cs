using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment
{
     class UsingStringArray
    {
        public static void array()
        {
            string[] names = new string[5] { "kiran", "Sagar", "manish", "Somesh", "Tushar" };
            {
                Console.WriteLine("Print names");

                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"names[{i}]={names[i]}");
                }
            }
        }
    }
}
