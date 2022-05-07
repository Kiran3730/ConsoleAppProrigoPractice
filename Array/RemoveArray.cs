using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    class RemoveArray
    {
        public static void removeArryElemt()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(" before remove");
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Enter element in array");
            int num = Convert.ToInt32(Console.ReadLine());
        
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    for (int j = i; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    break;
                }
            }

            Console.WriteLine(" After remove");
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
        }
    }
}