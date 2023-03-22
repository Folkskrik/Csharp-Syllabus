using System;

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

        public void Eat(Food food)
        {
            if (food = Meat)
            {
                _FoodEaten += food._Quantity;
            }
            else
            {
                Console.WriteLine("Tigers are not eating that type of food!");
            }
        }
    }
}