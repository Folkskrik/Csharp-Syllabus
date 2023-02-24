class Program
{
    static void Main()
    {
         Console.Write("Enter your weight in kilograms: ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter your height in meters: ");
        double height = double.Parse(Console.ReadLine());

        double bmi = weight / Math.Pow(height, 2);

        Console.WriteLine("Your BMI is: " + bmi.ToString("F2"));

        if (bmi < 18.5)
        {
            Console.WriteLine("You are underweight.");
        }
        else if (bmi >= 18.5 && bmi <= 25)
        {
            Console.WriteLine("Your weight is optimal.");
        }
        else
        {
            Console.WriteLine("You are overweight.");
        }

        Console.ReadLine();
    }
}