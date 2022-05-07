using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2.WAP create a object of StringBuilder class assign sample text using Append(), &use Insert(),
    Remove(), Replace() & display string*/

namespace ConsoleApp1.Array
{
    class StringB1
    {
        public static void stringb()
        {
            StringBuilder strsb = new StringBuilder("I am Kiran");
              Console.WriteLine(strsb.ToString());

              strsb.Append(" Designation is devloper");
              Console.WriteLine(strsb);

              strsb.Insert(5,"thanx you");
              Console.WriteLine(strsb);          

              strsb.Remove(15,5);             
              Console.WriteLine(strsb);
            
             strsb.Replace("Somesh", "kiran");
             Console.WriteLine(strsb);


        }
    }
}
