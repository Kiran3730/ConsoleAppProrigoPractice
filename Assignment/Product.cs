using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment
{
    class Product
    {
        // auto implemented property
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public static void employee()
        {

            // Product p1 = new Product { Id = 1, Name = "HP Laptop", Price = 34000 };
            Product[] productlist = new Product[3]
            {
                 new Product{Id=1,Name="HP Laptop",Price=34000},
                  new Product{Id=2,Name="Dell Laptop",Price=35000},
                   new Product{Id=3,Name="Lenovo Laptop",Price=36000},
             };

            foreach (Product p in productlist)
            {
                Console.WriteLine(p); //internally or implecitly ToString() get call 
            }
        }
        public override string ToString()
        {
            return $"product Id :{Id} product name :{Name} Price :{Price}";
        }
    }

}
        
