using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment
{
       public class Area
    {
        
        public static void areaa(float l)
        {
            float square = l * l;
            Console.WriteLine("Area of Square :" + square);
        }
        public static void areaa(double l, double b)
        {
          double  ar = l * b;
            Console.WriteLine("Area of rectange :" + ar);
        }

        public static void areaa(double r)
        {
            double cr = 3.14 * r * r;
            Console.WriteLine("Area of Circle :" + cr);
        }


        public static void AreaMethod()
        {
            Area.areaa((float)12.5);
            Area.areaa(12.56, 16);
            Area.areaa(9.5);
        }

    }
}

