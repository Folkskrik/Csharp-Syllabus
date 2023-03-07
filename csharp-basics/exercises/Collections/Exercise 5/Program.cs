using System;

class HappyNumberChecker
{
    static bool IsHappy(int number)
    {
        HashSet<int> seenNumbers = new HashSet<int>();
        while (number != 1)
        {
            int sum = 0;
            foreach (char digit in number.ToString())
            {
                int digitValue = digit - '0';
                sum += digitValue * digitValue;
            }
            number = sum;
            if (seenNumbers.Contains(number))
            {
                return false;
            }
            seenNumbers.Add(number);
        }
        return true;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        if (IsHappy(inputNumber))
        {
            Console.WriteLine($"{inputNumber} is a happy number!");
        }
        else
        {
            Console.WriteLine($"{inputNumber} is not a happy number.");
        }
    }
}