class Program
{
    static void Main(string[] args)
    {
        int num1, num2, sum, diff;

        Console.Write("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        sum = num1 + num2;
        diff = num1 - num2;

        if (num1 == 15 || num2 == 15 || sum == 15 || diff == 15 || diff == -15)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

        Console.ReadLine();
    }
}