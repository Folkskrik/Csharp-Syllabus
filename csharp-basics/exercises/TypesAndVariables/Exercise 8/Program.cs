class Program
{
    static void Main()
    {
        int minutes;
        int minutesPerDay = 1440;
        int minutesPerYear = 525600;

        Console.Write("Enter the number of minutes: ");
        minutes = int.Parse(Console.ReadLine());

        int years = minutes / minutesPerYear;
        int days = (minutes % minutesPerYear) / minutesPerDay;

        Console.WriteLine("{0} minutes is approximately {1} years and {2} days.", minutes, years, days);
    }
}