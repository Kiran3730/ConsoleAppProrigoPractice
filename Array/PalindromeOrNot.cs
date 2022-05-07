using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
     class PalindromeOrNot
    {
        public static void palindrome()
        {
            int num = 1221, rev = 0, rem;
            int temp = num;
            
            while(temp!=0)
            {
                rem = temp % 10;
                rev = rev * 10 + rem;
                temp = temp / 10;
            }
            if(num==rev)
            {
                Console.WriteLine(num + " number is palindrome");
            }
            else
            {
                Console.WriteLine(num + " number is not palindrome");
            }
        }
    }
}
