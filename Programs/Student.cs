using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
     class Student
    {

        public int rno, per;
        public string name = " ";

        public Student()
        {
           
            rno= 2;
            per = 2020;
            name = "kiran";
        }
        
        public void Display()
        {
            Console.WriteLine($"Student detail is:Roll no{rno},name={name},Percentage={per}");
        }

    }
}
