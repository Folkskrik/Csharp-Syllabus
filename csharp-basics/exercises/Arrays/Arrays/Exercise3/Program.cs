using System;

namespace Exercise3
{
    class Program
    {
        //TODO: Write a C# program to calculate the average value of array elements.
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("The sum of the numbers is: " + sum);

            int sum1 = 0;

            foreach (int number in numbers)
            {
                sum1 += number;
            }

            double average = (double)sum1 / numbers.Length;

            Console.WriteLine("Average value of the array elements is : " + average);
        }
    }
}
