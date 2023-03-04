using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine("Printing vowels using for loop:");
            for (int i = 0; i < vowels.Length; i++)
            {
                Console.Write(vowels[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Printing vowels using foreach loop:");
            foreach (char vowel in vowels)
            {
                Console.Write(vowel + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
