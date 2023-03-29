namespace ScooterRental
{
    public class InvalidPriceException : Exception
    {
        public InvalidPriceException() : base("Provided price in not valid. Only positive price is allowed")
        {

        }
    }
}