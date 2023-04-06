using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class MouseInvalidFoodException : Exception
    {
        public MouseInvalidFoodException() : base("Mouses do not eat that type of food")
        {
        }
    }
}