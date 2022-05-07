using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    class JaggedArray
    {
        public static void array1()
        {
            int[][] jaggedArray =
                {
                new int[] { 1, 2, 3 },
                new int[] { 10, 20 },
                new int[] { 1, 2, 3, 4 },
            };
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
