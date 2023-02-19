class Program
{
    static void Main()
    {
        Console.Write("Enter a series of single digit numbers: ");
        string input = Console.ReadLine();

        int sum = 0;
        int len = input.Length;

        for (int i = 0; i < len; i++)
        {
            sum += input[i] - '0';
        }

        Console.WriteLine($"The sum of the numbers is: {sum}");
    }
}