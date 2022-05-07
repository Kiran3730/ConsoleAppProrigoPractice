using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    public class SelectionSort
    {
        public static void selection()
        {
            int[] list= { 29, 72, 98, 13, 87 };
            Console.WriteLine("Before Selection Sort");
            foreach (int item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            for (int i = 0; i < list.Length - 1; i++)//4,
            {
 
 

            }
            Console.WriteLine("\nAfter Selection Sort\n");
            foreach (int item in list)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
