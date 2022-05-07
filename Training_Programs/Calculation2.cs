using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Training_Programs
{
    public delegate int MyDelegate1(int n1, int n2);
   
        public class Calculation2
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
            public int Sub(int a, int b)
            {
                return a - b;
            }
            public int Multiply(int a, int b)
            {
                return a * b;
            }
        

        public static void calculate2()
        {
            Calculation2 c = new Calculation2();
          
            MyDelegate1 mydel = new MyDelegate1(c.Add);
            mydel += new MyDelegate1(c.Add);
            mydel += new MyDelegate1(c.Multiply);
            mydel += new MyDelegate1(c.Sub);

            Delegate[] list = mydel.GetInvocationList();
            foreach (Delegate d in list)
            {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.DynamicInvoke(20, 30));
            }

        }

    }
}
