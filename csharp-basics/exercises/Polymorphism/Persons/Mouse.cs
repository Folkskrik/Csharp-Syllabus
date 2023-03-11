using Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            :base(name, "Mouse", weight, livingRegion)

            public override void MakeSound()
        {
            Console.WriteLine("Squeeek");
        }

        public override void Eat(Food food)
        {
            if (food = Vegetable)
            {
                FoodEaten += food.Quantity
            }
            else
            {
                Console.WriteLine($"{AnimalType}s are not eating that type of food!");
            }
        }
    }
}