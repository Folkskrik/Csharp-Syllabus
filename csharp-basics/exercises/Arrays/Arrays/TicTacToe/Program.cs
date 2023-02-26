using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        private static char currentPlayer = 'X';

        static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();

            bool gameOver = false;
            while (!gameOver)
            {
                Console.WriteLine($"'{currentPlayer}', choose your location (row, column): ");
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                if (board[row, col] == ' ')
                {
                    board[row, col] = currentPlayer;

                    DisplayBoard();

                    if (CheckWin(currentPlayer))
                    {
                        Console.WriteLine($"'{currentPlayer}' wins!");
                        gameOver = true;
                    }
                    else if (CheckTie())
                    {
                        Console.WriteLine("The game is a tie.");
                        gameOver = true;
                    }
                    else
                    {
                        currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
                    }
                }
                else
                {
                    Console.WriteLine("That spot is already taken. Try again.");
                }
            }

            Console.ReadLine();
        }

        private static void InitBoard()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    board[r, c] = ' ';
                }
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("   0   1   2");
            Console.WriteLine("  +---+---+---+");
            for (int r = 0; r < 3; r++)
            {
                Console.Write($"{r} ");
                for (int c = 0; c < 3; c++)
                {
                    Console.Write($"| {board[r, c]} ");
                }
                Console.Write("|");
                Console.WriteLine();
                Console.WriteLine("  +---+---+---+");
            }
        }

        private static bool CheckWin(char player)
        {
            for (int r = 0; r < 3; r++)
            {
                if (board[r, 0] == player && board[r, 1] == player && board[r, 2] == player)
                {
                    return true;
                }
            }

            for (int c = 0; c < 3; c++)
            {
                if (board[0, c] == player && board[1, c] == player && board[2, c] == player)
                {
                    return true;
                }
            }

            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            {
                return true;
            }

            if (board[2, 0] == player && board[1, 1] == player && board[0, 2] == player)
            {
                return true;
            }

            return false;
        }

        private static bool CheckTie()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (board[r, c] == ' ')
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}