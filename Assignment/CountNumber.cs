using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public  class CountNumber
    {
        public static void count()
        {
            int count = 0;
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());

            while(num>0)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine("number of count is " + count);
        }
    }
}
