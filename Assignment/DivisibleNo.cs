using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment
{
     class DivisibleNo
    {
        public static void division()
        {

           
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            {
               if((num%5==0) && (num%11==0))
               {
                    Console.WriteLine("number is divisible");
               }
                else
                {
                    Console.WriteLine("number is not divisible");
                }
            }
        }
    }
}
