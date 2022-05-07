using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Training_Programs
{
    class HashTable1
    {
        public static void table()
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "kiran");
            ht.Add(2, "somesh");
            ht.Add(3, "tushar");
            ht.Remove(1);

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }


        }
    }
}
