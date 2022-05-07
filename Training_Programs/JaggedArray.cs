using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Training_Programs
{
     class JaggedArray
    {
        public static void jagged()
        {
           
            
            int[][] jaggedArray =
                 {
                new int[] { 1, 2, 3 },
                new int[] { 1, 2 },
                new int[] { 1, 2, 3, 4 },
               
            };
            

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }

        }
    }
}
