using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
    public class Voterage
    {
        public static void age()
        {
            Console.WriteLine("Enter age");
            int age= Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("Valid for vote");
            }
            else
            {
                Console.WriteLine("Not valid for vote");
            }
        }
    }
}
