using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> jediOrder = new HashSet<string>();

        jediOrder.Add("Obi - Wan Kenobi");
        jediOrder.Add("Anakin Skywalker"); 
        jediOrder.Add("Mace Windu");
        jediOrder.Add("Ahsoka Tano");
        jediOrder.Add("Yoda");

        Console.WriteLine("Jedi in the order:");
        foreach (string jedi in jediOrder)
        {
            Console.WriteLine(jedi);
        }

        jediOrder.Clear();
        Console.WriteLine("After Order 66, there are no Jedi left in the Galaxy.");

        Console.WriteLine("Adding 'Obi-Wan Kenobi' to the set again...");
        if (!jediOrder.Add("Obi-Wan Kenobi"))
        {
            Console.WriteLine("'Obi-Wan Kenobi' is already in the order.");
        }

        jediOrder.Add("Darth Vader");
        Console.WriteLine("The dark side is growing. There are now only {0} beings in the Galaxy.", jediOrder.Count);
    }
}