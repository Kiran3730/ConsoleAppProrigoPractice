﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment
{
   public class Pattern7
    {
        public static void pattern()
        {
            for (int i = 7; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                   Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
