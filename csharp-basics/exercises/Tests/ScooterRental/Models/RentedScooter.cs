namespace ScooterRental.Models
{
    public class RentedScooter
    {
        public RentedScooter(string id, decimal pricePerMinute, DateTime rentStarted)
        {
            Id = id;
            PricePerMinute = pricePerMinute;
            RentStarted = rentStarted;
        }

        public string Id;
        public decimal PricePerMinute;
        public DateTime RentStarted;
        public DateTime? RentEnded;
    }
}