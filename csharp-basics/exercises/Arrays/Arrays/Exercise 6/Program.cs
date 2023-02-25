using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];

            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(1, 101);
            }

            int[] newArray = new int[myArray.Length];
            for (int i = 0; i < myArray.Length; i++)
            {
                newArray[i] = myArray[i];
            }

            myArray[myArray.Length - 1] = -7;

            Console.WriteLine("myArray:");
            foreach (int value in myArray)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            Console.WriteLine("newArray:");
            foreach (int value in newArray)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}