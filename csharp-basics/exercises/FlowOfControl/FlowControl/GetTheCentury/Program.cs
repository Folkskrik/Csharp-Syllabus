using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Century(1756));
            Console.WriteLine(Century(1555));
            Console.WriteLine(Century(1000));
            Console.WriteLine(Century(1001));
            Console.WriteLine(Century(2005));
        }
        static string Century(int year)
        {
            int century = (year - 1) / 100 + 1;
            string suffix;

            if (century >= 11 && century <= 13)
            {
                suffix = "th";
            }
            else if (century % 10 == 1)
            {
                suffix = "st";
            }
            else if (century % 10 == 2)
            {
                suffix = "nd";
            }
            else if (century % 10 == 3)
            {
                suffix = "rd";
            }
            else
            {
                suffix = "th";
            }
            return century.ToString() + suffix + " century";
        }
    }
}