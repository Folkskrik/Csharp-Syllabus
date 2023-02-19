namespace CozaLozaWoza
{
    class Program
    {
        static void Main(string[] args)
        {
            const int lowerBound = 1;
            const int upperBound = 110;
            const int numbersPerLine = 11;

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Coza");
                }
                if (i % 5 == 0)
                {
                    Console.Write("Loza");
                }
                if (i % 7 == 0)
                {
                    Console.Write("Woza");
                }
                if (i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                {
                    Console.Write(i);
                }

                if (i % numbersPerLine == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}