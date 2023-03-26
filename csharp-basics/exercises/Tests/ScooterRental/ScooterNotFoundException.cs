namespace ScooterRental
{
    public class ScooterNotFoundException : Exception

    {
        public ScooterNotFoundException() : base("Scooter with provided Id is not found")
        {

        }
    }
}
