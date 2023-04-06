using ScooterRental.Interfaces;
using ScooterRental.Models;

namespace ScooterRental.Services
{
    public class RentalCalculatorService : IRentalCalculator
    {
        private const decimal MaxDailyRent = 20.00m;

        public decimal CalculateRent(RentedScooter rental)
        {
            decimal rentalPrice = 0.0m;
            var rentalDuration = (rental.RentEnded - rental.RentStarted)?.TotalMinutes;
            var rentalDays = (rental.RentEnded - rental.RentStarted)?.TotalDays;

            if (rentalDuration > 0)
            {
                rentalPrice = (decimal)rentalDuration * rental.PricePerMinute;
                int elapsedDays = (int)rentalDays;
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