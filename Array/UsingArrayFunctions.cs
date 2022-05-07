using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment
{
    class UsingArrayFunctions
    {
        public static void functions()
        {
            int[] numbers = new int[] { 10, 20, 30, 40, 50, 60, 70 };
            foreach (int ii in numbers)
            {
                Console.WriteLine(ii);
            }
            Console.WriteLine("Enter wich number u want remove");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<=numbers.Length-1;i++)
            {
                if (numbers[i] == num)
                {
                   // numbers.re;
                }
                   
                
            }
             foreach (int ii in numbers)
            {
                Console.WriteLine(ii);
            }


            /*  Array.Sort(numbers);
              Console.WriteLine("After sort");
              foreach (int ii in numbers)
              {
                  Console.WriteLine(ii);
              }

              Array.Reverse(numbers);
              Console.WriteLine("After reverse");
              foreach (int ii in numbers)
              {
                  Console.WriteLine(ii);
              }

              Array.Clear(numbers, 4, 3);
              Console.WriteLine("After clear");
              foreach (int ii in numbers)
              {
                  Console.WriteLine(ii);
              }

              Array.Copy(numbers, numbers, 4);
              Console.WriteLine("After copy");
              foreach (int ii in numbers)
              {
                  Console.WriteLine(ii);


  */





        }
        }
    }


