using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
     class TwoDArray
    {
        public static void array()
        {
            int[,] marks = new int[4, 5];
            Console.WriteLine("Enter 20 numbers in array");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    marks[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"{marks[i, j]}");

                }
                Console.WriteLine();
            }
        }
    }
}
