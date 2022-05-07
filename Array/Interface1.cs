using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
     interface Interface1
    {
        public interface ICustomer
        {
            void Print();
        }
        public interface IOrder
        {
            void Print();
        }
        public class Transaction : ICustomer, IOrder
        {
            void ICustomer.Print()
            {
                Console.WriteLine("Customer details name-tushar");
            }

            void IOrder.Print()
            {
                Console.WriteLine("Customer has purchase 1. mobile 2. mouse");
            }
        }


        public static void display()
        {
            ICustomer c = new Transaction();
            c.Print();

            IOrder i = new Transaction();
            i.Print();
        }

    }
}
