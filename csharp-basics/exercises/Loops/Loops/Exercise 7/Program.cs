using System;

namespace PigletGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");

            int score = 0;
            bool gameOver = false;

            while (!gameOver)
            {
                int roll = RollDice();

                if (roll == 1)
                {
                    Console.WriteLine("You rolled a 1!");
                    score = 0;
                    gameOver = true;
                }
                else
                {
                    Console.WriteLine("You rolled a " + roll + "!");
                    score += roll;

                    Console.Write("Roll again? ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "n" || input.ToLower() == "no")
                    {
                        gameOver = true;
                    }
                }
            }

            Console.WriteLine("You got " + score + " points.");
        }

        static int RollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}