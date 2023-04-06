using ScooterRental.Models;
using ScooterRental.Services;

namespace ScooterRental.Interfaces
{
    public interface IRentalCalculator
    {
        decimal CalculateRent(RentedScooter rental);
    }
}