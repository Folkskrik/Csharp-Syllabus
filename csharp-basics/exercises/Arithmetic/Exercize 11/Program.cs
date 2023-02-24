public class HarshadMoran
{
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
        static int SumDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
        static string Moran(int n)
    {
        int sum = SumDigits(n);
        if (sum == 0) return "Neither";
        if (n % sum == 0)
        {
            int quotient = n / sum;
            if (IsPrime(quotient))
            {
                return "M";
            }
            else
            {
                return "H";
            }
        }
        else
        {
            return "Neither";
        }
    }
        public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The number is: " + Moran(n));
    }
}