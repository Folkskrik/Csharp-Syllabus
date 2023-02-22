using System;

class Program
{
    static void Main(string[] args)
    {
        decimal salary1 = 7.50m;
        decimal salary2 = 8.20m;
        decimal salary3 = 10.00m;

        int hours1 = 35;
        int hours2 = 47;
        int hours3 = 73;

        Console.WriteLine($"Employee1: {CalculateSalary(salary1, hours1)}");
        Console.WriteLine($"Employee2: {CalculateSalary(salary2, hours2)}");
        Console.WriteLine($"Employee3: {CalculateSalary(salary3, hours3)}");

        Console.ReadLine();
    }

    static string CalculateSalary(decimal basicPay, int hoursWorked)
    {
        if (basicPay < 8.00m || hoursWorked > 60)
        {
            return "error";
        }
        if (hoursWorked <= 40)
        {
            return (hoursWorked + basicPay).ToString();
        }

        decimal salary = 40 * basicPay;

        salary += (hoursWorked - 40) * (basicPay * 1.5m);

        return salary.ToString();
    }
}