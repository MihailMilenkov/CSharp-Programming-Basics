﻿namespace CSharpProgrammingBasics._06NestedConditionalStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _06FruitOrVegetable
    {
        internal static void Start()
        {
            string input = Console.ReadLine();

            if (input == "banana" || input == "apple" || input == "kiwi" || input == "cherry" || input == "lemon" || input == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (input == "tomato" || input == "cucumber" || input == "pepper" || input == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
