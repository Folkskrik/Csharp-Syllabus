namespace ScooterRental
{
    public class RentalCompany : IRentalCompany
    {
        private readonly IScooterService _scooterService;
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
        }

        public decimal EndRent(string id)
        {
            throw new NotImplementedException();
        }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            throw new NotImplementedException();
        }
    }
}
