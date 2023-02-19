class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int guess = 0;

        Console.WriteLine("I'm thinking of a number between 1-100. Try to guess it.");

        while (guess != secretNumber)
        {
            Console.Write("> ");
            if (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Invalid input, please enter a valid integer.");
                continue;
            }
            if (guess < secretNumber)
            {
                Console.WriteLine("Sorry, you are too low. I was thinking of {0}.", secretNumber);
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Sorry, you are too high. I was thinking of {0}.", secretNumber);
            }
            else
            {
                Console.WriteLine("You guessed it! What are the odds?!?");
            }
        }
    }
}