using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    public class DecendinngOrder
    {
        public static void order()
        {
            string[] names =
            {"kiran","somesh","mahesh","ganesh","ramesh","kalpesh","mangesh","dinesh","naresh","adesh"};

            String temp;
            foreach (string i in names)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            for (int i = 0; i < names.Length-1; i++)//
            {
                for (int j = 0; j < names.Length - i - 1; j++)//
                {
                    if (names[j].CompareTo(names[j + 1]) > 0)
                                {
                        temp = names[j];//                                  
                        names[j] = names[j + 1];//                            
                        names[j + 1] = temp;//                               
                    }                                                   
                }
            }
            Console.WriteLine("After Descending orders");
            foreach (string i in names)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
        
