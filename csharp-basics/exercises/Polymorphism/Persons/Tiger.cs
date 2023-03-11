using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Tiger : Felime
    {
        public Tiger(string name, double weight, string livingRegion)
            :base(name, "Tiger", weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Rawr!");
        }

        public override void Eat(Food food)
        {
            if (food = Meat)
            {
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine("Tigers are not eating that type of food!")
            }
        }
    }
}