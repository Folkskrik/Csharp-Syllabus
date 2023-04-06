using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental.Exceptions
{
    public class ScooterNotRentedEcxeption : Exception
    {
        public ScooterNotRentedEcxeption() : base("Scooter is not rented")
        {

        }
    }
}
