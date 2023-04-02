using ScooterRental.Interfaces;
using ScooterRental.Models;

namespace ScooterRental.Services
{
    public class RentalCalculatorService : IRentalCalculator
    {
        private const decimal MaxDailyRent = 20.00m;

        public decimal CalculateIncome(IList<RentedScooter> rentedScooters)
        {
            throw new NotImplementedException();
        }

        public decimal CalculateRent(RentedScooter rental)
        {
            decimal rentalPrice = 0.0m;
            TimeSpan rentalDuration = DateTime.UtcNow - rental.StartTimeUtc;

            if (rentalDuration.TotalMinutes > 0)
            {
                rentalPrice = (decimal)rentalDuration.TotalMinutes * rental.PricePerMinute;
                int elapsedDays = (int)rentalDuration.TotalDays;
                if (elapsedDays > 0)
                {
                    decimal dailyRent = 0.0m;
                    for (int i = 0; i < elapsedDays; i++)
                    {
                        dailyRent += MaxDailyRent;
                    }
                    rentalPrice = dailyRent;
                }
            }

            return rentalPrice;
        }
    }
}