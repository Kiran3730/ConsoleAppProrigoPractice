using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
  internal  class Palindrome
    {
        public static void number()
        {
          int  maximum = 500;

            Console.WriteLine("Palindrome Numbers between 1 and: " +maximum);

            for(int num =1;num<=maximum;num++)
            {
                int temp = num;
                int reverse = 0;

                while (temp > 0)
                {
                    int Reminder = temp % 10;
                    reverse = (reverse * 10) + Reminder;
                    temp = temp / 10;
                }

                if (num == reverse)
                {
                    Console.Write("  "+num); 
                }
            }
   



        }
    }
}

    


