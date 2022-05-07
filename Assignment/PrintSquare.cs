using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
 public class PrintSquare
    {
       
            public static void square()
            { 
           
            int square=0 ;
            int num = 20;
            Console.WriteLine("Square of number  : ");

                for (int i = 1; i <= num; i++)
                {
                    square = i * i;
                    Console.WriteLine(i + " Sqaure ==>" + square);
                }

            }
        }
        
        

    }

