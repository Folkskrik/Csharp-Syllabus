using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int sum = Math.Add(num1, num2);
        int diff = Math.Abs(Math.Subtract(num1, num2));

        if (num1 == 15 || num2 == 15 || sum == 15 || diff == 15)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

        Console.ReadLine();
    }
}