using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Cat : Felime
    {
        public string Breed { get; set; }

        public Cat(string name. double weight, string livingRegion, string breed)
            : base(name, "Cat", weight, livingRegion)
        {
            Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow")
        }

        public override void Eat(Food food)
        {
            FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return base,ToString() + $"{Breed}]";
    }
}