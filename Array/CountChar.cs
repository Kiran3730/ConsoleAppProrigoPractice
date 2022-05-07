using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    public class CountChar
    {
        public static void count()
        {
            string str = "kiran";
            int count=0;
            for(int i=0;i<str.Length;i++)
            {
                count++;
                
            }
            Console.WriteLine("No of character is == " + count);
        }

    }
}
