using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
    public class EvenSeries
    {
        static void methodEven()
        {
       
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());


             for(int i=1;i<=num;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                    
                }
            }

        }
    }
}
