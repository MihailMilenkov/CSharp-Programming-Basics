﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics._02SimpleOperations
{
    class DivisionWithRemainders
    {
        internal static void Start()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = a % b;
            Console.WriteLine(c);
        }
    }
}
