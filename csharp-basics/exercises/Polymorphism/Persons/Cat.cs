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
            _FoodEaten += food._Quantity;
        }

        public override string ToString()
        {
            return base.ToString() + $"{_Breed}]";
        }
    }
}