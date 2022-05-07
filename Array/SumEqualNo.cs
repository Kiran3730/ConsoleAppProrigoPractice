using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    public class SumEqualNo
    {
        public static void sum()
        {
            /*int[] arr = new int[] { 4, 5, 0 , 7, 1, 2, 3, 6 };
            int sum=7;
            for(int i=0;i<arr.Length-1;i++)
            {
                for (int j =0; j < arr.Length-1; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {

                        Console.WriteLine(arr[i]+" + "+arr[j]+" = "+sum);
                    }
                    
                }
            }*/

            int[] arr = new int[4] { 4, 5, 3, 6 };
            int sum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {

                sum = sum + arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}
