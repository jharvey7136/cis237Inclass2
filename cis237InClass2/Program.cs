﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            factorial factorial = new factorial();

            Console.Write("The answer to 5! is: ");
            Console.WriteLine(factorial.Calculate(5));
        }
    }
}
