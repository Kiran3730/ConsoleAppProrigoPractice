using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    public class ReplaceNo
    {
        public static void number()
        {
            int[] arr = new int[11] { 26, 0, 67,45,0,78,54,34,10,0,34 };
            int  temp = 0;
            for(int i=0;i<=arr.Length-1;i++)
            {
                 if(arr[i] ==0)   
                {
                   temp= arr[i] ;
                    arr[i] = 1;
                }
            }
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
