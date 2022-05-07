using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    public class Product1
    {

        public int id;
        public string name;
        public double price;
        public Product1(int pid, String pname, double pprice)
        {
            id = pid;
            name = pname;
            price = pprice;

        }
        public Product1(String name, int pid, double pprice)
        {
            name = "name";
            id = pid;
            price = pprice;
        }
        public override String ToString()
        {
            return $"Product id:{id} product name:{name}Product price:{price}";
        }
        
    }
   
}
