using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = "../Histogram/midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllText(Path);
            var scores = readText.Split(' ').Select(int.Parse).ToList();

            var histogram = new int[11];

            foreach (var score in scores)
            {
                if (score < 0 || score > 100)
                {
                    Console.WriteLine($"Invalid score: {score}");
                    continue;
                }

                histogram[score / 10]++;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i * 10:00}-{i * 10 + 9:00}: {new string('*', histogram[i])}");
            }

            Console.WriteLine($"  100: {new string('*', histogram[10])}");
        }
    }
}