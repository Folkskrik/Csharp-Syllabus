class Program
{
    static void Main()
    {
        Console.Write("Enter distance in meters: ");
        double distance = double.Parse(Console.ReadLine());

        Console.Write("Enter time taken (hours): ");
        int hours = int.Parse(Console.ReadLine());
        Console.Write("Enter time taken (minutes): ");
        int minutes = int.Parse(Console.ReadLine());
        Console.Write("Enter time taken (seconds): ");
        int seconds = int.Parse(Console.ReadLine());

        int totalSeconds = hours * 3600 + minutes * 60 + seconds;

        double speedMps = distance / totalSeconds;

        double speedKph = (distance / 1000.0) / (totalSeconds / 3600.0);

        double speedMph = (distance / 1609.0) / (totalSeconds / 3600.0);

        Console.WriteLine($"Your speed in meters/second is {speedMps:F8}");
        Console.WriteLine($"Your speed in km/h is {speedKph:F8}");
        Console.WriteLine($"Your speed in miles/h is {speedMph:F8}");
    }
}