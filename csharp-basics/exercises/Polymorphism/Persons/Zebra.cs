using System;

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
            Console.WriteLine("Braaaayy");
        }

        public override void Eat(Food food)
        {
            if(food is Vegetable)
            {
                FoodEaten += (int)food.Quantity;
            }
            else
            {
                throw new ZebaraFoodInvalidException();
            }
        }

        public override string ToString()
        {
            return $"{Type} [{Name}, {Weight.ToString("0.##")}, {_livingRegion}, {FoodEaten}]";
        }
    }
}