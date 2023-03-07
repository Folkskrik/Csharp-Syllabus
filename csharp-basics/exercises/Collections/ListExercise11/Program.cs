using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>
            {
                "Car",
                "Lightsaber",
                "Magic",
                "Wand",
                "Red",
                "Jet",
                "PC",
                "Movie",
                "Game",
                "Console"
            };

            list.Insert(4, "Anakin");
            string lastPosition = list[list.Count - 1];

            list.Sort();

            Console.WriteLine(string.Join(",", list));

            if (list.Contains("Foobar"))
            {
                Console.WriteLine("The list contains the element of Foobar.");
            }
            else
            {
                Console.WriteLine("The list does not contain the element of Foobar.");
            }
        }
    }
}