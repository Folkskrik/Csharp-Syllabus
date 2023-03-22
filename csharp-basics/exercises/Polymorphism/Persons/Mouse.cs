using System;

namespace Persons
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, "Mouse", weight, livingRegion)
        { 
        }

            public override void MakeSound()
        {
            Console.WriteLine("Squeeek");
        }

        public void Eat(Food food)
        {
            if (food = Vegetable)
            {
                _FoodEaten += food._Quantity;
            }
            else
            {
                Console.WriteLine($"{_Type}s are not eating that type of food!");
            }
        }
    }
}