using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment
{
    class PyramidPattern
    {
        public static void pattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= 1; j--)
                {
                    if (j > i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(" *");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
