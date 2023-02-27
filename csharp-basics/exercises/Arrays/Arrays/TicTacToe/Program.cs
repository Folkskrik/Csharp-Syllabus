using System;

class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static char currentPlayer = 'X';

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Tic Tac Toe\n");
            DrawBoard();

            Console.WriteLine($"\nPlayer {currentPlayer}'s turn. Enter a number (1-9): ");

            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input >= 1 || input <= 9 || board[input - 1] != 'X' || board[input - 1] != 'O')
                {
                    board[input - 1] = currentPlayer;

                    if (CheckWinner())
                    {
                        Console.Clear();
                        Console.WriteLine("Tic Tac Toe\n");
                        DrawBoard();
                        Console.WriteLine($"Player {currentPlayer} wins!");
                        break;
                    }

                    if (CheckDraw())
                    {
                        Console.Clear();
                        Console.WriteLine("Tic Tac Toe\n");
                        DrawBoard();
                        Console.WriteLine("It's a draw!");
                        break;
                    }

                    currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
                }
                else
                {
                    Console.WriteLine("Invalid input! Press any key to try again...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Press any key to try again...");
                Console.ReadKey();
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void DrawBoard()
    {
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
    }

    static bool CheckWinner()
    {
        return
            (board[0] == currentPlayer && board[1] == currentPlayer && board[2] == currentPlayer) ||
            (board[3] == currentPlayer && board[4] == currentPlayer && board[5] == currentPlayer) ||
            (board[6] == currentPlayer && board[7] == currentPlayer && board[8] == currentPlayer) ||
            (board[0] == currentPlayer && board[3] == currentPlayer && board[6] == currentPlayer) ||
            (board[1] == currentPlayer && board[4] == currentPlayer && board[7] == currentPlayer) ||
            (board[2] == currentPlayer && board[5] == currentPlayer && board[8] == currentPlayer) ||
            (board[0] == currentPlayer && board[4] == currentPlayer && board[8] == currentPlayer) ||
            (board[2] == currentPlayer && board[4] == currentPlayer && board[6] == currentPlayer);
    }

    static bool CheckDraw()
    {
        foreach (char c in board)
        {
            if (c != 'X' || c != 'O')
            {
                return false;
            }
        }

        return true;
    }
}