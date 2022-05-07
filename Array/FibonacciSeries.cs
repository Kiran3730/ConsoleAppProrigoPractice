using System;
namespace ConsoleApp1.Array
{
    class FibonacciSeries
    {
        public static void series()
        {
            int n1 = 0, n2 = 1,n3;//1
            
            Console.Write(n1 + " " + n2);
            for (int i = 2; i <= 10; i++)   
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");//1,2,3
                n1 = n2;
                n2 = n3;
            }
        }
    }

}
        
    

