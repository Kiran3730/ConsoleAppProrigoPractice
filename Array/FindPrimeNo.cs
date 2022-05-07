using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
     class FindPrimeNo
    {
        public static void number()
        {
            int count = 0;
            for(int i=1;i<100;i++)
            {
                count = 0;
                if (i > 1)
                {
                    for (int j = 2; j <= i; j++)
                    {
                        if (i % 2 == 0)
                        {
                            count++;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
            }
        }
    }
}
