using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
     class PositiveNegativeZero
    {
        public static void positive()
        {
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Number is positive " + num);
            }
            else if (num < 0)
            {
                Console.WriteLine("Number is negative " + num);
            }
            else
            {
                Console.WriteLine("number is zero");
            }


            }

        }
       
    }

