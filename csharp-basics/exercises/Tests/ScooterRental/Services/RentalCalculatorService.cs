using ScooterRental.Interfaces;
using ScooterRental.Models;

namespace ScooterRental.Services
{
    public class RentalCalculatorService : IRentalCalculator
    {
        public decimal CalculateIncome(IList<RentedScooter> rentedScooters)
        {
            throw new NotImplementedException();
        }

        public decimal CalculateRent(RentedScooter rental)
        {
            return 20.00m;
        }
    }
}