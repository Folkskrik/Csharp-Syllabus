using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            string firstWord = Console.ReadLine();

            Console.WriteLine("Enter second word:");
            string secondWord = Console.ReadLine();

            int dotCount = 30 - firstWord.Length - secondWord.Length;
            string dots = "";
            for (int i = 0; i < dotCount; i++)
            {
                dots += ".";
            }

            string output = firstWord + dots + secondWord;
            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}