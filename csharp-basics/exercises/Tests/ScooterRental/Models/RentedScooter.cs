namespace ScooterRental.Models
{
    public class RentedScooter
    {
        private const decimal MaxDailyRentalAmount = 20m;

        public RentedScooter(string id, decimal pricePerMinute, DateTime rentStarted)
        {
            Id = id;
            PricePerMinute = pricePerMinute;
            RentStarted = rentStarted;
            StartTimeUtc = rentStarted.ToUniversalTime();
        }

        public string Id { get; }
        public decimal PricePerMinute { get; }
        public DateTime RentStarted { get; private set; }
        public DateTime? RentEnded { get; set; }
        public DateTime StartTimeUtc { get; private set; }
        public DateTime EndTimeUtc { get; set; }
        public decimal TotalAmount { get; private set; }

        public void EndRent(DateTime rentEnded)
        {
            RentEnded = rentEnded;
            EndTimeUtc = rentEnded.ToUniversalTime();
            var rentalTime = (decimal)(EndTimeUtc - StartTimeUtc).TotalMinutes;
            var rentalAmount = rentalTime * PricePerMinute;

            if (TotalAmount + rentalAmount >= MaxDailyRentalAmount)
            {
                var nextDay = RentEnded.Value.Date.AddDays(1);
                RentStarted = nextDay;
                StartTimeUtc = nextDay.ToUniversalTime();
                TotalAmount = rentalAmount;
            }
            else
            {
                TotalAmount += rentalAmount;
            }
        }

    }
}