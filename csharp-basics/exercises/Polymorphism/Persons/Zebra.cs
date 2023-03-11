using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Zebra : Mammal
    {
        public Zebra(string name, double weight, string livingRegion)
            : base(name, "Zebra", weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Braaaayy")
        }

        public override void Eat(Food food)
        {
            if(food is Vegetable)
            {
                FoodEaten += (int)food.Quantity;
            }
            else
            {
                Console.WriteLine($"{AnimalType}s are not eating that type of food!");
            }
        }

        public override string ToString()
        {
            return $"{AnimalType} [{AnimalType}, {AnimalWeight.ToString("0.##")}, {LivingRegion}, {FoodEaten}]";
        }
    }
}