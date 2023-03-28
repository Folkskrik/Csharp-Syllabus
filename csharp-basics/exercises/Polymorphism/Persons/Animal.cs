namespace Persons
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public Animal(string name, string type, double weight)
        {
            Name = name;
            Type = type;
            Weight = weight;
            FoodEaten = 0;
        }

        public abstract void MakeSound();

        public abstract void Eat(Food food);

        public abstract string ToString();
    }
}