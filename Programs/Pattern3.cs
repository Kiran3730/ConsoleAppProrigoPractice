using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
     class Pattern3
    {
        public static void pattern()
        {
            for (int i = 1; i <= 5; i++) 
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
