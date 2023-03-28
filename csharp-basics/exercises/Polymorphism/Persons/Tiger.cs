using System;

namespace Persons
{
    public class Tiger : Felime
    {
        public Tiger(string name, double weight, string livingRegion)
            : base(name, "Tiger", weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Rawr!");
        }

        public override void Eat(Vegetable vegetable)
        {
            Console.WriteLine("Tigers are not eating that type of food!");
        }

        public override void Eat(Meat meat)
        {
            _FoodEaten += meat.Quantity;
        }
    }
}