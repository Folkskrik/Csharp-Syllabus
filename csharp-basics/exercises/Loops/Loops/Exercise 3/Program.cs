using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            Random random = new Random();
            {
                for (int i = 0; i < 20; i++)
                {
                    numbers[i] = random.Next(1, 101);
                }
                Console.WriteLine("Enter the position of a numer from 1-20 you want to know: ");
                int position = Convert.ToInt32(Console.ReadLine());

                if (position < 1 || position > 20)
                {
                    Console.WriteLine("Not a valid position. Please! enter a number between 1 and 20 next time.");
                }
                else
                {
                    int number = numbers[position - 1];
                    Console.WriteLine("The number at position " + position + " is " + number + ".");
                }
                Console.ReadKey();
            }
        }
    }
}