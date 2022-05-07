using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
    public  class  Employee
    {
        protected Employee()
        {
            Console.WriteLine("Employee Salary");
        }
    }

    public class Manager : Employee
    {
        public virtual void salary(int fa,int ta,int bo,int sal)
        {
            sal = fa + ta + bo;
            Console.WriteLine("Manager Salry"+sal);
        }

    }
    public class president : Manager
    {
        public override void salary(int fa, int ta, int bo, int sal)
        {
            base.salary(fa, ta, bo, sal);
            sal = fa + ta+bo;
            Console.WriteLine("Precident Salry" + sal);
        }
    }
}
