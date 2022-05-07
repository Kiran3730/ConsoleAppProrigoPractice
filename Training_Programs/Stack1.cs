using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Training_Programs
{

    public class Stack1
    {
        public static void prod()
        {
            Stack my_stack = new Stack();

            my_stack.Push(10);
            my_stack.Push(20);
            my_stack.Push(30);
            my_stack.Push(40);
            my_stack.Push(50);

            my_stack.Pop();
          //  my_stack.Clear();

            foreach (var elem in my_stack)
            {
                Console.WriteLine(elem);

            }
        }
    }
}





