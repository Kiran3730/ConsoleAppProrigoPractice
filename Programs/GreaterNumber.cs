using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
    class GreaterNumber
    {
        public static void greater()
        {

            Console.WriteLine("Enter first  number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(" greater number is " + num1);
            }
            if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(" greater number is " + num2);
            }
            else
            {
                Console.WriteLine(" greater number is " + num3);
            }

        }
    }
}
