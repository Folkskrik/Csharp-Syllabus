using System;

// Using nested-if statement

namespace PrintDayInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the day number (0-6): ");
            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber == 0)
            {
                Console.WriteLine("Sunday");
            }
            else if (dayNumber == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (dayNumber == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (dayNumber == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (dayNumber == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (dayNumber == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (dayNumber == 6)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("Not a valid day");
            }
        }
    }
}

/*
  // Using switch-case-default statement

namespace PrintDayInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the day number (0-6): ");
            int dayNumber = int.Parse(Console.ReadLine());

            switch (dayNumber)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Not a valid day");
                    break;
            }
        }
    }
}
*/