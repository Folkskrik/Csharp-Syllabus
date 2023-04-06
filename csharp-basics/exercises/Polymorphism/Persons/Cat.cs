using System;

namespace Persons
{
    public class Cat : Felime
    {
        public string _Breed { get; set; }

        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, "Cat", weight, livingRegion)
        {
            _Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public override void Eat(Food food)
        {
            FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{Type} [{Name}, {Weight.ToString("0.##")}, {_livingRegion}, {FoodEaten}, {_Breed}]";
        }
    }
}