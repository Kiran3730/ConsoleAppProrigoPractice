using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment
{
     class CharPattern
    {
        public static void pattern()
        {
            for (char i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'D'; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
