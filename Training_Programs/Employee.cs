using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Training_Programs
{
     class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Salary { get; set; }
        public string Dept { get; set; }


        public static void details()
        {
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee { Id = 1, Name = "sagar",City="Sangamner", Salary = 20000,Dept="jhg" },
                new Employee { Id = 2, Name = "aman",City = "nagar", Salary = 30000, Dept = "hgbv" },
                new Employee { Id = 3, Name = "nadim", City = "pune",Salary = 60000, Dept = "csaa" },
                new Employee { Id = 4, Name = "karim", City = "nashik", Salary = 50000, Dept = "HR" },
                new Employee { Id = 5, Name = "salim", City = "sinnar", Salary = 60000, Dept = "vbvc" },
                new Employee { Id = 6, Name = "saurabh", City = "baner", Salary = 70000, Dept = "cghn" },
                new Employee { Id = 7, Name = "somesh", City = "pune", Salary = 80000, Dept = "HR" },
                new Employee { Id = 8, Name = "tushar", City = "akole", Salary = 90000, Dept = "kjhvf" },
                new Employee { Id = 9, Name = "amol", City = "mumbai", Salary = 10000, Dept = "vggb" },
            };

            var result = from e in employeeList
                         where e.Salary > 45000
                         select e;

            /* var result = from e in employeeList
                          orderby e.Name
                          select e;*/

            /* var result = from e in employeeList
                           where e.City.Contains("mumbai")
                           select e;*/

            /* var result = from e in employeeList
                          where e.Dept.Contains("HR")
                          select e;*/

            /*var result = from e in employeeList
                         orderby e.Salary descending
                          select e;*/

            /*var result = from e in employeeList
                         where e.Name.StartsWith('a') || e.Name.StartsWith('k')
                         select e;*/

            /*var result = from e in employeeList
                         where e.City.Contains("pune") && e.Salary > 40000
                         select e;*/


            foreach (Employee e in result)
            {
                Console.WriteLine($"{e.Name} {e.Salary} ");
            }
        }


    }
}
