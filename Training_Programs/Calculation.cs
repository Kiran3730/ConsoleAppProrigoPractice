using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Training_Programs
{
    public delegate int MyDelegate(int n1, int n2);

    public class Calculation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }


        public static void calculate()
        {
            Calculation c = new Calculation();
            MyDelegate mydel = new MyDelegate(c.Add);

            int res = mydel.Invoke(10, 70);
            Console.WriteLine(res);


        }
    }
}



    