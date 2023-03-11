using Exercise_13;
using System;

class Program
{
    static void Main(string[] args)
    {
        Smoothie s1 = new Smoothie(new string[] { "Banana" });
        Console.WriteLine($"Ingredients: {string.Join(", ", s1.Ingredients)}");
        Console.WriteLine($"Cost: {s1.GetCost()}");
        Console.WriteLine($"Price: {s1.GetPrice()}");
        Console.WriteLine($"Name: {s1.GetName()}");

        Console.WriteLine();

        Smoothie s2 = new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries" });
        Console.WriteLine($"Ingredients: {string.Join(", ", s2.Ingredients)}");
        Console.WriteLine($"Cost: {s2.GetCost()}");
        Console.WriteLine($"Price: {s2.GetPrice()}");
        Console.WriteLine($"Name: {s2.GetName()}");
    }
}