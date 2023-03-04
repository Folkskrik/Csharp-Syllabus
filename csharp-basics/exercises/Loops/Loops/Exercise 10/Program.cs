using System;
class NumberSquare
{
    static void Main()
    {
        Console.Write("Min? ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Max? ");
        int max = int.Parse(Console.ReadLine());

        for (int i = 0; i < max - min + 1; i++)
        {
            int current = min + i;
            for (int j = 0; j < max - min + 1; j++)
            {
                Console.Write(current);
                current++;
                if (current > max)
                {
                    current = min;
                }
            }
            Console.WriteLine();
        }
    }
}