using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
    class SumOfNumber
    {
        public static void sum()
        {
            int sum = 0;
            Console.WriteLine("Enter number");///
            int num = Convert.ToInt32(Console.ReadLine());///////

            for (int i = 0; i <= num; i++)
            {
               
                    sum = sum + i;
                }
                Console.WriteLine("Sum of number is"+sum);
                }
            }
        }
    
    

