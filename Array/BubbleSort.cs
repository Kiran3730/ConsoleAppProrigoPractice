using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    public class BubbleSort
    {
        public static void sorting()
        {
            int[] list = new int[5] { 7, 5, 3, 4, 2 };
            int num = 5, temp;
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }

            for (int i = 0; i < num - 1; i++)//4
            {
                for (int j = 0; j < num - i - 1; j++)//4,
                {
                    if (list[j] > list[j + 1])//index of array, 0>1=f,    7 5 3 4 2
                    {                                                  // 5 7 3 4 2 
                        temp = list[j];//                                  5 3 7 4 2   
                        list[j] = list[j + 1];//                            5 3 4 7 2
                        list[j + 1] = temp;//                               5 3 4 2 7
                    }                           //                          3
                }
            }
            Console.WriteLine();
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
