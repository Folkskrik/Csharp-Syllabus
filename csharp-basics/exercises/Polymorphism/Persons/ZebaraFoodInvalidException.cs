using System;

namespace Persons
{
    public class ZebaraFoodInvalidException : Exception
    {
        public ZebaraFoodInvalidException() : base("Zebras do not eat that type of food")
        {
        }
    }
}