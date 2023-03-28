namespace Persons
{
    public abstract class Animal
    {
        public abstract string _Name { get; set; }
        public abstract string _Type { get; set; }
        public abstract double _Weight { get; set; }
        public abstract int _FoodEaten { get; set; }

        public Animal(string name, string type, double weight)
        {
            _Name = name;
            _Type = type;
            _Weight = weight;
            _FoodEaten = 0;
        }

        public abstract void MakeSound();

        public abstract void Eat(Food food);

        public override string ToString()
        {
            return $"{_Type} [{_Name}, {_Weight:F1}, {_FoodEaten}]";
        }
    }
}