using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment
{
	class GreadingSystem
	{
		public static void greading()
		{
			/* a. Below 25 - E
			 b. 20 to 40 - D
			 c. 40 to 60 - C
			 d. 60 to 80 - B
			 e. Above 80 - A
			 
			*/
			Console.WriteLine("Enter the marks");
			int marks = Convert.ToInt32(Console.ReadLine());


			if (marks < 20)
			{
				Console.WriteLine("grade is E");
			}
			else if (marks >=20  && marks < 40)
			{
				Console.WriteLine("grade is D");	
			}
			else if (marks >= 40 && marks < 60)
			{
				Console.WriteLine("grade is C");
			}
			else if (marks >= 60 && marks < 80)
			{
				Console.WriteLine("grade is B");
			}
			else
			{
				Console.WriteLine("grade is A");
			}
		}
	}
}

