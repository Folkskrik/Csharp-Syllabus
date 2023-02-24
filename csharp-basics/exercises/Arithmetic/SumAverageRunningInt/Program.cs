using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            double average;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number) 
            {
                sum += number;
            }
            average = (double)sum / (upperBound - lowerBound + 1);

            Console.WriteLine("The sum of {0} to {1} is {2}", lowerBound, upperBound, sum);
            Console.WriteLine("The average is {0:F1}", average);
        }
    }
}
