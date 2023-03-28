using System;
using System.Xml.Linq;

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

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                FoodEaten += (int)food.Quantity;
            }
            else
            {
                throw new TigroFoodInvalidException();
            }
        }

        public override string ToString()
        {
            return $"{Type} [{Name}, {Weight.ToString("0.##")}, {_livingRegion}, {FoodEaten}]";
        }
    }
}