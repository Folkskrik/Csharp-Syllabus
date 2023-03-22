namespace Persons
{
    public abstract class Food
    {
        public int _Quantity { get; set; }

        protected Food(int quantity)
        {
            _Quantity = quantity;
        }
    }
}