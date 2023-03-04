using System;
class RollTwoDice
{
    static void Main()
    {
        Random random = new Random();
        int desiredSum;

        Console.Write("Desired sum (between 2 and 12): ");
        while (!int.TryParse(Console.ReadLine(), out desiredSum) || desiredSum < 2 || desiredSum > 12)
        {
            Console.Write("Invalid input. Please enter the desired sum between 2 and 12: ");
        }

        int dice1, dice2, sum;
        do
        {
            dice1 = random.Next(1, 7);
            dice2 = random.Next(1, 7);
            sum = dice1 + dice2;
            Console.WriteLine("{0} and {1} = {2}", dice1, dice2, sum);
        } while (sum != desiredSum);
    }
}