namespace AdApp
{
    public class TVAd: Advert
    {
        public TVAd(int fee, int v) : base(fee)
        {
        }

        public TVAd(int fee, int v, int v1, bool v2) : this(fee, v)
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