using ScooterRental.Interfaces;

namespace ScooterRental
{
    public class RentalCompany : IRentalCompany
    {
        private readonly IScooterService _scooterService;
        private readonly IRentalCalculator _rentalCalculator;
        private readonly IRentalArchive _rentedScooters;
        public RentalCompany(string name,
            IScooterService scooterService,
            IRentalArchive rentedScooters,
            IRentalCalculator rentalCalculator
            )
        {
            Name = name;
            _scooterService = scooterService;
            _rentalCalculator = rentalCalculator;
            _rentedScooters = rentedScooters;
        }
        public string Name { get; }
        public void StartRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);
            _rentedScooters.AddRent(scooter.Id, scooter.PricePerMinute, DateTime.UtcNow);
            scooter.IsRented = true;
        }

        public decimal EndRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);
            var rental = _rentedScooters.EndRent(scooter.Id, DateTime.UtcNow);

            scooter.IsRented = false;

            return _rentalCalculator.CalculateRent(rental);
        }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            return _rentalCalculator.CalculateIncome(_rentedScooters.GetRentedScooterArchive());
        }
    }
}