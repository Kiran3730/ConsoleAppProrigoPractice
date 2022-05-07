using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Training_Programs
{
    class Product3
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public static void Productdetails()
        {
            List<Product3> productList = new List<Product3>()
            {
                new Product3 { Id = 1, Name = "Hp laptop", Price = 20000 },
                new Product3 { Id = 2, Name = "Dell laptop", Price = 30000 },
                new Product3 { Id = 3, Name = "Acer laptop", Price = 40000 },
                new Product3 { Id = 4, Name = "Lenovo laptop", Price = 50000 },
                new Product3 { Id = 5, Name = "Apple laptop", Price = 60000 },
            };

           var result1 = from pp in productList 
                         where pp.Price < 35000
                         select pp;
              
            foreach (Product3 pp in result1)
            {
                Console.WriteLine($"{pp.Name} {pp.Price}");
            }


        }


    }
}
