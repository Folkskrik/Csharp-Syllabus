using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        string message;
        if (number % 2 == 0)
        {
            message = "Even Number";
        }
        else
        {
            message = "Odd Number";
        }

        Console.WriteLine(message);
        Console.WriteLine("bye!");
        Console.ReadLine();
    }
}