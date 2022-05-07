using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
    public class Date
    {
        public int day, month, year;
        public Date()
        {
            Console.WriteLine("Default constructr run!!");
            day = 7;
            month = 3;
            year = 2020;
        }
       /* public Date(int dd,int mm,int yy)
        {
            day=dd;
            month=mm;
            year = yy;
            Console.WriteLine("Parameterise constructr run!!");
        }*/
        public void Display()
        {
            Console.WriteLine($"date is:{day}/{month}/{year}");

        }
       


    }
}
