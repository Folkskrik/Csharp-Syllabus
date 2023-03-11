using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public abstract class Food
    {
        public int Quantity { get; set; }

        protected Food(int quantity)
        {
            Quantity = quantity;
        }
    }
}