using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    // 1. WAP to create 2D array of 3*4 matrix,copy array one to another & display

    class CopyAndDisplay
    {
        public static void copy()
        {
            int[,] arr = new int[3, 4]
            {
            { 1,2,3,2},
            { 4,5,6,8},
            { 3,8,9,2},
            };

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    Console.Write($" {arr[i, j]}");
                }
                Console.WriteLine();

            }
        }
    }
}
