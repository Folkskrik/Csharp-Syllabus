using System;

namespace Persons
{
    public abstract class Mammal : Animal
    {
        public string _livingRegion;

        protected Mammal(string name, string type, double weight, string livingRegion)
            : base(name, type, weight)
        {
            _livingRegion = livingRegion;
        }
    }
}