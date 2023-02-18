class Program
{
    static void Main(string[] args)
    {
        // take user input for distance in meters
        Console.Write("Enter distance in meters: ");
        double distance = double.Parse(Console.ReadLine());

        // take user input for time in hours, minutes, and seconds
        Console.Write("Enter time in hours: ");
        double hours = double.Parse(Console.ReadLine());
        Console.Write("Enter time in minutes: ");
        double minutes = double.Parse(Console.ReadLine());
        Console.Write("Enter time in seconds: ");
        double seconds = double.Parse(Console.ReadLine());

        // calculate total time in seconds
        double totalTimeInSeconds = (hours * 3600) + (minutes * 60) + seconds;

        // calculate speed in meters/second
        double speedInMetersPerSecond = distance / totalTimeInSeconds;

        // calculate speed in km/h
        double speedInKmPerHour = (distance / 1000.0) / (totalTimeInSeconds / 3600.0);

        // calculate speed in miles/h
        double speedInMilesPerHour = (distance / 1609.0) / (totalTimeInSeconds / 3600.0);

        // display the results
        Console.WriteLine("Your speed in meters/second is: " + speedInMetersPerSecond);
        Console.WriteLine("Your speed in km/h is: " + speedInKmPerHour);
        Console.WriteLine("Your speed in miles/h is: " + speedInMilesPerHour);
    }
}