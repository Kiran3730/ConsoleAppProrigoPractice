using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Training_Programs
{
    class DictionaryDemo
    {
        public static void demo()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(91, "IND");
            d.Add(34, "PAK");
            d.Add(33, "CHIN");
            d.Add(56, "JAPAN");
            d.Add(32, "RUS");

            foreach (KeyValuePair<int, string> item in d)
            {
                Console.WriteLine(item.Key + "  " + item.Value); ;
            }


        }

    }
}
