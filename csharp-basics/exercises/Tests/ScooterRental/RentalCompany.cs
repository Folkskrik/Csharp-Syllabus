using ScooterRental.Interfaces;
using ScooterRental.Models;

namespace ScooterRental
{
    public class RentalCompany : IRentalCompany
    {
        private IScooterService _scooterService;
        private IRentalCalculator _rentalCalculator;
        private IRentalArchive _rentedScooters;

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

            if (rental == null)
            {
                throw new InvalidOperationException("Scooter is not rented");
            }

            scooter.IsRented = false;

            var rentalPrice = _rentalCalculator.CalculateRent(rental);

            var rentalDuration = rental.EndTimeUtc - rental.StartTimeUtc;
            if (rentalDuration >= TimeSpan.FromDays(1))
            {
                var rentalDays = (int)Math.Ceiling(rentalDuration.TotalDays);
                var maxPricePerDay = 20m;

                var pricePerDay = rentalPrice / rentalDays;

                if (pricePerDay > maxPricePerDay)
                {
                    rentalPrice = maxPricePerDay * rentalDays;
                }
            }

            return rentalPrice;
        }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            var rentedScooters = _rentedScooters.GetRentedScooterArchive();

            if (year.HasValue)
            {
                rentedScooters = rentedScooters.Where(r => r.StartTimeUtc.Year == year.Value).ToList();
            }

            if (includeNotCompletedRentals)
            {
                var now = DateTime.UtcNow;

                foreach (var scooter in _scooterService.GetScooters())
                {
                    if (scooter.IsRented)
                    {
                        var rental = new RentedScooter(scooter.Id, scooter.PricePerMinute, now);
                        rentedScooters.Add(rental);
                    }
                }
            }

            return _rentalCalculator.CalculateIncome(rentedScooters);
        }

    }
}