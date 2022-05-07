using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment
{
    class PrimeNo
    {
        public static void prime()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Number is prime number");
            }
            else
            {
                Console.WriteLine("Number is not prime number");
            }
        }
    }
}
/*Scanner sc = new Scanner(System.in);
System.out.println("Enter number");
int num = sc.nextInt();
int temp = num;
int sum = 0;
while (num > 0)
{
    int r = num % 10;
    sum = sum + (r * r * r);
    num = num / 10;
}
num = temp;
if (sum == temp)
{
    System.out.println("Armstrong number");
}
else
{
    System.out.println("Not Armstrong number");
}
	}

}
*/

/*String str, rev = "";
Scanner sc = new Scanner(System.in);
System.out.println("Enter string");
str = sc.nextLine();
int length = str.length();

for (int i = length - 1; i >= 0; i--)
{
    rev = rev + str.charAt(i);


    if (str.equals(rev))
    {
        System.out.println(str + "Number is Palindrome");
    }
    else
    {
        System.out.println(str + "Number is not Palindrome");



    }*/

/*public class CountDigit
{
    public static void main(String[] args)
    {
        // TODO Auto-generated method stub

        int count = 0, num = 30;
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter number:");
        num = sc.nextInt();
        for (int i = 1; i <= 30; i++)
        {
            if (i % 2 == 1)
            {
                num = num / 10;
                count++;
            }
        }
        System.out.println("Number of digits " + count);

    }

}*/

//public class Swapping


   /* public static void main(String[] args)
    {

        int num1 = 10, num2 = 20;

        System.out.println("Before Swapping");
        System.out.println("num1=" + num1);
        System.out.println("num2=" + num2);

        int temp = num1;
        num1 = num2;
        num2 = temp;

        System.out.println("After swap");
        System.out.println("num1=" + num1);
        System.out.println("num2=" + num2);

    }*/
