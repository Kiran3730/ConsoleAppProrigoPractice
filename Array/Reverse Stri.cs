using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    class Reverse_Stri
    {
        public static void reverse()
        {
            /*string str = "kiran";
            string rev = "";
            int length;
            length = str.Length - 1;
            while(length >= 0)
            {
                rev = rev + str[length];
                length--;
            }
      
                Console.WriteLine("Reverse string is :" + rev);
            }*/

            String str = "kiran";
             string rev = "";

           //char[] chArray =str.ToCharArray();
          //  string rev = String.Empty;
             for(int i = str.Length - 1; i >= 0; i--)

          //  for (int i=0; i >=str.Length - 1; i--)
            {
                rev=rev + str[i];
            }
            Console.WriteLine("Reverse string is :" + rev);
        }
    }
    }

 
