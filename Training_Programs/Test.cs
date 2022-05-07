using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Training_Programs
{
    public class Testc : IComparer
    {
        public int Compare(object x, object y) 
        {
            Product prod1 = (Product)x; 
            Product prod2 = (Product)y;
            if (prod1.Price > prod2.Price)
                return 1;
            else
                return 0;

        }

        public static void Objcreatemethod()
        {
            Product p1 = new Product (1,"Hp laptop",37000 );
            Product p2 = new Product ( 2,"Dell laptop", 35000);
            Testc test = new Testc();
            int result = test.Compare(p1, p2);

            if (result == 1)
            {
                Console.WriteLine("HP laptop have more price than Dell");
            }
            else
            {
                Console.WriteLine("Dell laptop have more price than HP");
            }



        }

    }
}