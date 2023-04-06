using ScooterRental.Interfaces;
using ScooterRental.Models;

namespace ScooterRental
{
    public class RentalCompany : IRentalCompany
    {
        private IScooterService _scooterService;
        private IRentalCalculator _rentalCalculator;
        private IRentalArchive _rentedScooters;
        private IList<IncomeRecords> _recordedIncome;

        public RentalCompany(
            string name,
            IScooterService scooterService,
            IRentalArchive rentedScooters,
            IRentalCalculator rentalCalculator
        )
        {
            Name = name;
            _scooterService = scooterService;
            _rentalCalculator = rentalCalculator;
            _rentedScooters = rentedScooters;
            _recordedIncome = new List<IncomeRecords>();
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
            if (string.IsNullOrEmpty(id))
            {
                throw new ScooterIdNotProvidedException();
            }

            var scooter = _scooterService.GetScooterById(id);

            var rental = _rentedScooters.EndRent(scooter.Id, DateTime.UtcNow);

            scooter.IsRented = false;

            var rentalPrice = _rentalCalculator.CalculateRent(rental);

            var money = new IncomeRecords() { Year = DateTime.Now.Year, Price = rentalPrice, };

            _recordedIncome.Add(money);

            return rentalPrice;
        }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            var rentedScooters = _recordedIncome;

            decimal endYearIncome = 0;

            if (year.HasValue)
            {
                foreach (var rentedScooter in rentedScooters)
                {
                    if (year == rentedScooter.Year)
                    {
                        endYearIncome += rentedScooter.Price;
                    }
                }
            }

            if (includeNotCompletedRentals)
            {
                foreach (var scooter in _rentedScooters.GetRentedScooterArchive())
                {
                    if (scooter.RentEnded == null)
                    {
                        var now = DateTime.UtcNow;

                        decimal time = (decimal)(now - scooter.RentStarted).TotalMinutes;

                        endYearIncome += time * scooter.PricePerMinute;
                    }
                }
            }

            return endYearIncome;
        }
    }
}