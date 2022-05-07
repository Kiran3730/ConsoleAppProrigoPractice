using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment
{
    class UsingForEach
    {

        public static void numbers()
        {
            // int[] number = new int[] { 10, 20, 30, 40, 50 };
            int[] number = new int[5];
            Console.WriteLine("Enter elements in array");
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
                Console.WriteLine("Print array");

                foreach (int no in number)
                {
                    Console.WriteLine(no);
                }
            }
        }
    }

