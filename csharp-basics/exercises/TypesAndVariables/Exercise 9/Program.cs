class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter distance in meters: ");
        double distance = double.Parse(Console.ReadLine());

        Console.Write("Enter time in hours: ");
        double hours = double.Parse(Console.ReadLine());
        Console.Write("Enter time in minutes: ");
        double minutes = double.Parse(Console.ReadLine());
        Console.Write("Enter time in seconds: ");
        double seconds = double.Parse(Console.ReadLine());

        double totalTimeInSeconds = (hours * 3600) + (minutes * 60) + seconds;

        double speedInMetersPerSecond = distance / totalTimeInSeconds;

        double speedInKmPerHour = (distance / 1000.0) / (totalTimeInSeconds / 3600.0);

        double speedInMilesPerHour = (distance / 1609.0) / (totalTimeInSeconds / 3600.0);

        Console.WriteLine("Your speed in meters/second is: " + speedInMetersPerSecond);
        Console.WriteLine("Your speed in km/h is: " + speedInKmPerHour);
        Console.WriteLine("Your speed in miles/h is: " + speedInMilesPerHour);
    }
}