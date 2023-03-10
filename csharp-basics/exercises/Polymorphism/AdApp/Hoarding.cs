namespace AdApp
{
    public class Hoarding: Advert
    {
        private int rate;
        //per day
        private int numDays;

        public Hoarding(int fee) : base(fee)
        {
        }

        public Hoarding(int fee, int v1, int v2) : this(fee)
        {
        }

        public new int Cost() 
        {
            return (int)base.Cost();
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}