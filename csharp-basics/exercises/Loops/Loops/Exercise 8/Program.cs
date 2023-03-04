using System;
class AsciiFigure
{
    static void Main()
    {
        Console.Write("Enter the size of the figure: ");
        int size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size * 4 - 4 - i * 4; j++)
            {
                Console.Write("/");
            }
            for (int j = 0; j < i * 8; j++)
            {
                Console.Write("*");
            }
            for (int j = 0; j < size * 4 - 4 - i * 4; j++)
            {
                Console.Write("\\");
            }
            Console.WriteLine();
        }
    }
}