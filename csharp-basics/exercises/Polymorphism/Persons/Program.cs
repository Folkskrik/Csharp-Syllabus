using System;
using System.Collections.Generic;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Mouse("Jerry", 0.1, "House - Basement"),
                new Zebra("Marty", 350, "Land - Africa"),
                new Cat("Tom", 2.5, "Home", "Persian"),
                new Tiger("Sergey", 200, "Jungle")
            };

            Console.WriteLine(animals[0]);
            animals[0].MakeSound();
            animals[0].Eat(new Vegetable(3));
            Console.WriteLine(animals[0]);

            Console.WriteLine(animals[1]);
            animals[1].MakeSound();
            animals[1].Eat(new Meat(13));
            Console.WriteLine(animals[1]);

            Console.WriteLine(animals[2]);
            animals[2].MakeSound();
            animals[2].Eat(new Meat(3));
            Console.WriteLine(animals[2]);

            Console.WriteLine(animals[3]);
            animals[3].MakeSound();
            animals[3].Eat(new Vegetable(13));
            Console.WriteLine(animals[3]);
        }
    }
}