using System;

namespace Exercise2
{
    class Program
    {       
        // TODO: Write a C# program to sum values of an array.
        // Array values are starting from min (including) till max (including) number. 
        private static void Main(string[] args)
        {
            var sum = 0;

            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());

            int arrayLength = maxNumber - minNumber + 1;
            int[] numbers = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                numbers[i] = minNumber + i;
            }

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
