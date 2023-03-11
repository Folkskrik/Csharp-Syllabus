using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract string Type { get; set; }
        public abstract string Weight { get; set; }
        public abstract string FoodEaten { get; set;}

        protected Animal(string name, string type, double weight)
        {
            Name = name;
            Type = type;
            Weight = weight;
            FoodEaten = 0;
        }

        public abstract void MakeSound();

        public abstract void Eat();

        public override string ToString()
        {
            return $"{Type} [{Name}, {Weight:F1}, {FoodEaten}]";
        }
    }
}