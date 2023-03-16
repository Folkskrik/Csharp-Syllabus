namespace Persons
{
    public abstract class Mammal : Animal
    {
        public string _LivingRegion { get; set; }

        protected Mammal(string name, string type, double weight, string livingRegion)
            : base(name, type, weight)
        {
            _LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $" {_LivingRegion}, ";
        }
    }
}