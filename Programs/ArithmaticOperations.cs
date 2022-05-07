using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
    public class ArithmaticOperations
    {
        public static void arithmatic()
        {
            int add, sub, mul, div;
            Console.WriteLine("Enter first number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            add = num1 + num2;
            Console.WriteLine("Addition of two numbers:"+add);

            sub = num1 - num2;
            Console.WriteLine("Substraction of two numbers:"+sub);

            mul = num1 * num2;
            Console.WriteLine("Multiplication of two numbers:"+mul);

            div = num1 / num2;
            Console.WriteLine("Division of two numbers:"+div);
        }

    }
}
