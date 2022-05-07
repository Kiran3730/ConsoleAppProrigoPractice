using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Training_Programs
{
     class DictionaryDemo2
    {
        public static void demo()
        {
            Dictionary<int, Product> dlist = new Dictionary<int, Product>();
            dlist.Add(1, new Product(121, "Book", 3000));
            dlist.Add(2, new Product(122, "Pen", 4000));
            dlist.Add(3, new Product(123, "Laptop", 300000));
            dlist.Add(4, new Product(124, "Notes", 23300));

            foreach (KeyValuePair<int, Product> item in dlist)
            {
                Console.WriteLine($"{item.Key} {item.Value.Name} {item.Value.Price}");
            }
        }
    }
}
