using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
    class Pattern6
    {
        public static void pattern()
        {
            int count = 0;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    count = count + 1;
                    Console.Write(count + "");
                }
                Console.WriteLine();
            }
        }
    }
}
