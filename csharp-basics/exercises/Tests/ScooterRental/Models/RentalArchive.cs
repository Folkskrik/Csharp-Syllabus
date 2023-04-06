using ScooterRental.Interfaces;
using System.Linq;

namespace ScooterRental.Models
{
    public class RentalArchive : IRentalArchive
    {
        private List<RentedScooter> _rentedScooterList;

        public RentalArchive(List<RentedScooter> rentedScooter)
        {
            _rentedScooterList = rentedScooter;
        }

        public void AddRent(string id, decimal pricePerMinute, DateTime rentStart)
        {
            _rentedScooterList.Add(new RentedScooter(id, pricePerMinute, rentStart));
        }

        public RentedScooter EndRent(string id, DateTime rentEnd)
        {
            var rental = _rentedScooterList.SingleOrDefault(s => s.Id == id && !s.RentEnded.HasValue);
            rental.RentEnded = rentEnd;
            return rental;

        }

        public IList<RentedScooter> GetRentedScooterArchive()
        {
            return _rentedScooterList.ToList();
        }
    }
}
