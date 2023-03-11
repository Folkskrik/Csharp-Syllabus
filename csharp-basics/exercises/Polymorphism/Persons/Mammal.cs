using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; set; }

        protected Mammal(string name, string type, double weight, string livingRegion)
            :base(name, type, weight)
        {
            LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            retunr base.ToString + $" {LivingRegion}, ";
        }
    }
}