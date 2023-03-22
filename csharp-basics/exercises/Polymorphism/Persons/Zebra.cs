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

        public void Eat(Food food)
        {
            if(food is Vegetable)
            {
                _FoodEaten += (int)food._Quantity;
            }
            else
            {
                Console.WriteLine($"{_Type}s are not eating that type of food!");
            }
        }

        public override string ToString()
        {
            return $"{_Type} [{_Type}, {_Weight.ToString("0.##")}, {_LivingRegion}, {_FoodEaten}]";
        }
    }
}