using System;
class Program
{
    static void Main()
    {
        string s1 = "Happy Birthday";
        string s2 = "MANY THANKS";
        string s3 = "sPoNtAnEoUs";

        Console.WriteLine(ReverseCase(s1));
        Console.WriteLine(ReverseCase(s2));
        Console.WriteLine(ReverseCase(s3));
    }
    static string ReverseCase(string str)
    {
        char[] chars = str.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            char c = chars[i];
            if (Char.IsLower(c))
            {
                chars[i] = Char.ToUpper(c);
            }
            else if (Char.IsUpper(c))
            {
                chars[i] = Char.ToLower(c);
            }
        }
        return new string(chars);
    }
}