class Program
{
    static void Main()
    {
        string input;
        int count, i, len;

        Console.Write("Enter a string: ");
        input = Console.ReadLine();

        count = 0;
        len = input.Length;

        for (i = 0; i < len; i++)
        {
            if (Char.IsUpper(input[i]))
            {
                count++;
            }
        }

        Console.WriteLine("The number of uppercase letters in the string is: " + count);
    }
}