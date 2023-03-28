namespace ScooterRental
{
    public class RentalCompany : IRentalCompany
    {
        private readonly IScooterService _scooterService;
        private DateTime _starTime;
        private DateTime _endTime;
        public RentalCompany(string name, IScooterService scooterService)
        {
            Name = name;
            _scooterService = scooterService;
        }
        public string Name { get; }
        public void StartRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);
            scooter.IsRented = true;
            _starTime = DateTime.Now;
        }

        public decimal EndRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);
            var pricePerMin = scooter.PricePerMinute;
            _endTime = DateTime.Now;
            var rentTime = (_endTime - _starTime).TotalMinutes;
            var totalCost = pricePerMin * (decimal)rentTime;
            scooter.IsRented = false;
            return totalCost;
        }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            throw new NotImplementedException();
        }
    }
}