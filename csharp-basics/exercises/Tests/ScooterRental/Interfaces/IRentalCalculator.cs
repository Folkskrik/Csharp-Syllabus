using ScooterRental.Models;
using ScooterRental.Services;

namespace ScooterRental.Interfaces
{
    public interface IRentalCalculator
    {
        decimal CalculateIncome(IList<RentedScooter> rentedScooters);
        decimal CalculateRent(RentedScooter rental);
    }
}