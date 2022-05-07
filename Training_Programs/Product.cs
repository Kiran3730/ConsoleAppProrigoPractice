using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Training_Programs
{
    public class Product : IComparable

    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Product(int Id, string Name, int Price)
        {
            this.Price = Price;
            this.Id = Id;
            this.Name = Name;
        }

       

        
       
        public int CompareTo(object obj) 
        {

            Product p2 = (Product)obj; 
                                  
            
            if (this.Price > p2.Price) 
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static void objcreatemethod()
        {
            Product p1 = new Product(1, "Hp laptop", 37000 );
            Product p2 = new Product(2, "Dell laptop", 40000); ;

            int result = p1.CompareTo(p2);
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
