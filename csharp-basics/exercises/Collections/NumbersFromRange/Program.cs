using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersFromRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var random = new Random();
            var numbers = new List<int>();
            while (numbers.Count() < 10)
            {
                numbers.Add(random.Next(1, 100));
            }

            var filteredNumbers = numbers.Where(n => n > 30 && n < 100).ToList();
            Console.WriteLine("Numbers greater than 30 and less than 100:");
            foreach (var number in filteredNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}