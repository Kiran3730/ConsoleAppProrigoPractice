using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment
{
     class EmployeeInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public static void employee()
        {

           EmployeeInformation[] employeelist = new EmployeeInformation[3]
            {
                new EmployeeInformation{Id=1,Name="sagar",Salary=34000},
                 new EmployeeInformation{Id=2,Name="harish",Salary=35000},
                  new EmployeeInformation{Id=3,Name="kiran",Salary=36000},
             };

            foreach (EmployeeInformation e in employeelist)
            {
                Console.WriteLine(e); 
            }
        }
        public override string ToString()
        {
            return $"employee Id :{Id} employee name :{Name} salary :{Salary}";
        }
    }

}
       
    
