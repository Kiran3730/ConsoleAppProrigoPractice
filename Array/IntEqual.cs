using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    // Check if two arrays (of integers) are equal.
    class IntEqual
    {
        public static void number()
        {
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };

            int[] arr2 = new int[5] { 1, 2, 3,5,4};
            if(arr1.Length==arr2.Length)
            {
                int i;
                int count = 0;
                
                for (i = 0; i < arr1.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr1[i] == arr2[j])
                        {
                            count++;
                        }
                    }

                }
                if (count == arr1.Length & count == arr2.Length)
                {
                    Console.WriteLine("Array are equal");
                }
                else
                {
                    Console.WriteLine("Array are not equal");
                }
            }
            else
            {
                Console.WriteLine("Given Arrays Not Equal");
            }
            
        }
    }
}
