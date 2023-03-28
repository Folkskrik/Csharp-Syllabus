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

        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                FoodEaten += food.Quantity;
            }
            else
            {
                throw new MouseInvalidFoodException();
            }
        }

        public override string ToString()
        {
            return $"{Type} [{Name}, {Weight.ToString("0.##")}, {_livingRegion}, {FoodEaten}]";
        }
    }
}