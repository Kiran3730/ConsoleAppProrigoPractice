using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
  public  class OddNumber
    {
        //print all odd no btn 521 to 229
        public static void odd()
        {
            int i = 521, num = 229;

            while(i>num)
            {
                if(i%2!=0)
                {
                    Console.Write(i+" ");

                   
                }
                i--;
            }
        }
    }
}
