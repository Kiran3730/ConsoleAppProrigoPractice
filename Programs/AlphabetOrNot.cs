using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
     class AlphabetOrNot
    {
        public static void alphabet()
        {
            Console.WriteLine("Enter character");
            char ch = Convert.ToChar(Console.ReadLine());

            if ((ch >= 'A' && ch <= 'z') || (ch >= 'a' && ch <= 'z'))
            {
                Console.WriteLine(ch +" Character is alphabet ");
            }
            else
            {
                Console.WriteLine(ch +" Character is not alphabet ");
            }
        }
                    
    }    
}
