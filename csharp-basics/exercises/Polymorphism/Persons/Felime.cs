using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public abstract class Felime : Mammal
    {
        protected Felime(string name, string type, double weight, string livingRegion)
            :base(name, type, weight, livingRegion)
    }
}