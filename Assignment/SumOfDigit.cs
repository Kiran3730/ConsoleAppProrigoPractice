using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment
{
     class SumOfDigit
    {
        public static void sum()
        {
            int sum = 0, fdigit, ldigit;
            Console.WriteLine("Enter the Digit");
            int digit = Convert.ToInt32(Console.ReadLine());

            if (digit > 99 && digit < 999)
            {
                ldigit = digit % 10;
                while (digit >= 10)
                {
                    digit = digit / 10;
                }
                fdigit = digit;
                sum = fdigit + ldigit;
                Console.WriteLine("Sum of first and last Digit is: " + sum);
            }
            else
            {
                Console.WriteLine("number is not three digit");
            }

            }

        }
    }

