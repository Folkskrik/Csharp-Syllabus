using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>()
            {
                "apple",
                "banana",
                "cherry",
                "grape",
                "orange",
                "pineapple",
                "strawberry",
                "watermelon"
            };

            Random rand = new Random();
            string wordToGuess = words[rand.Next(words.Count)];
            char[] lettersToGuess = wordToGuess.ToCharArray();
            char[] currentGuess = new char[wordToGuess.Length];
            for (int i = 0; i < currentGuess.Length; i++)
            {
                currentGuess[i] = '_';
            }
            int guessesLeft = 6;
            List<char> incorrectGuesses = new List<char>();

            while (guessesLeft > 0 && new string(currentGuess) != wordToGuess)
            {
                Console.WriteLine("Word: " + new string(currentGuess));
                Console.WriteLine("Misses: " + string.Join(", ", incorrectGuesses));
                Console.Write("Guess: ");
                char guess = Console.ReadLine().ToLower()[0];

                bool correctGuess = false;
                for (int i = 0; i < lettersToGuess.Length; i++)
                {
                    if (lettersToGuess[i] == guess)
                    {
                        currentGuess[i] = guess;
                        correctGuess = true;
                    }
                }

                if (!correctGuess)
                {
                    incorrectGuesses.Add(guess);
                    guessesLeft--;
                }
            }

            Console.WriteLine("Word: " + new string(currentGuess));
            Console.WriteLine("Misses: " + string.Join(", ", incorrectGuesses));
            if (guessesLeft == 0)
            {
                Console.WriteLine("Sorry, you ran out of guesses. The word was: " + wordToGuess);
            }
            else
            {
                Console.WriteLine("Congratulations, you guessed the word!");
            }

            Console.Write("Play again? (y/n): ");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain == "y")
            {
                Main(args);
            }
        }
    }
}
