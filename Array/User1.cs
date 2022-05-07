using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    public class User1
    {
        public class NameException : Exception
            {
                public NameException(string message) : base(message)
                {
                }
            }
            public class User2
            {
                public void AcceptName(String Name)
                {
                    if (string.IsNullOrEmpty(Name))
                    {
                    throw new NameException("Name  is Requird");
                    }
                    else
                    {
                        Console.WriteLine($"Your Name Is {Name}");


                    }
                }
                public static void Display()
                {
                    User2 User = new User2();
                    try
                    {
                        User.AcceptName("ram");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }



                }
            }
        }
    }

