using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var names = new HashSet<string>();

        while (true)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                break;
            }

            names.Add(name);
        }

        Console.WriteLine("Unique name list contains: " + string.Join(" ", names));
    }
}
