decimal salary1;
decimal salary2;
decimal salary3;

int hours1;
int hours2;
int hours3;

salary1 = 7.50m;
salary2 = 8.20m;
salary3 = 10.00m;

hours1 = 35;
hours2 = 47;
hours3 = 73;

Console.WriteLine($"Employee1: {CalculateSalary(salary1, hours1)}");
Console.WriteLine($"Employee2: {CalculateSalary(salary2, hours2)}");
Console.WriteLine($"Employee3: {CalculateSalary(salary3, hours3)}");

static string CalculateSalary (decimal basicPay, int hoursWorked)
{
    if (basicPay < 8.00m || hoursWorked > 60)
    {
        return "error";
    }
    if (hoursWorked <= 40)
    {
        return (hoursWorked + basicPay).ToString();
    }

    var salary = 40 * basicPay;

    salary += (hoursWorked - 40) * (basicPay * 1.5m);

    return salary.ToString();
}
