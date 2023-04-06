using System;

namespace Persons
{
    public class TigroFoodInvalidException : Exception
    {
        public TigroFoodInvalidException() : base("Tigers do not eat that type of food")
        {
        }
    }
}