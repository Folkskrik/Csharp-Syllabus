
class Program
{
    static void Main()
    {
        // Input distance in meters
        Console.Write("Enter distance in meters: ");
        double distance = double.Parse(Console.ReadLine());

        // Input time in hours, minutes, and seconds
        Console.Write("Enter time taken (hours): ");
        int hours = int.Parse(Console.ReadLine());
        Console.Write("Enter time taken (minutes): ");
        int minutes = int.Parse(Console.ReadLine());
        Console.Write("Enter time taken (seconds): ");
        int seconds = int.Parse(Console.ReadLine());

        // Convert time to total seconds
        int totalSeconds = hours * 3600 + minutes * 60 + seconds;

        // Calculate speed in meters per second
        double speedMps = distance / totalSeconds;

        // Calculate speed in kilometers per hour
        double speedKph = (distance / 1000.0) / (totalSeconds / 3600.0);

        // Calculate speed in miles per hour
        double speedMph = (distance / 1609.0) / (totalSeconds / 3600.0);

        // Output results
        Console.WriteLine($"Your speed in meters/second is {speedMps:F8}");
        Console.WriteLine($"Your speed in km/h is {speedKph:F8}");
        Console.WriteLine($"Your speed in miles/h is {speedMph:F8}");
    }
}