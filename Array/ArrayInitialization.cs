using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment
{
    class ArrayInitialization
    {
        public static void array()
        {
                int[] rainfall = new int[5]; 
                Console.WriteLine("Enter elements in array");
                for (int i = 0; i < rainfall.Length; i++)
                {
                   rainfall[i]=Convert.ToInt32(Console.ReadLine());
                }
                    Console.WriteLine("Print array");
                for (int i = 0; i < rainfall.Length; i++)
                {
                    Console.WriteLine($" rainfall[{i}]={ rainfall[i]}");
                }
            }
        }
    }

