namespace Product1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 10;
            int product = 1;

            for (int i = 1; i <= N; i++)
            {
                product *= i;
            }

            Console.WriteLine("The product of integers from 1 to {0} is: {1}", N, product);
        }
    }
}