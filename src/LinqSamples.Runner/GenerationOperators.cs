﻿using System;
using System.ComponentModel;
using System.Linq;

namespace LinqSamples.Runner
{
    public class GenerationOperators
    {
        [Category("Generation Operators")]
        [Description("This sample uses Range to generate a sequence of numbers from 100 to 149 " +
             "that is used to find which numbers in that range are odd and even.")]
        public void Linq65()
        {
            var numbers =
                from n in Enumerable.Range(100, 50)
                select new { Number = n, OddEven = n % 2 == 1 ? "odd" : "even" };

            foreach (var n in numbers)
            {
                Console.WriteLine("The number {0} is {1}.", n.Number, n.OddEven);
            }
        }

        [Category("Generation Operators")]
        [Description("This sample uses Repeat to generate a sequence that contains the number 7 ten times.")]
        public void Linq66()
        {
            var numbers = Enumerable.Repeat(7, 10);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
