using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
    class Pattern4
    {
        public static void pattern()
        {

            for (char i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
