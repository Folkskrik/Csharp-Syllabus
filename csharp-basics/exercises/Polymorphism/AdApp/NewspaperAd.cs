namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int column;
        private int rate;

        public NewspaperAd(int fee, int v) : base(fee)
        {
        }

        public NewspaperAd(int fee, int v, int v1) : this(fee, v)
        {
        }

        private new int Cost()
        {
            var fee = base.Cost();
            return (int)fee;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}