using System;

public class Program
{
    public static void Main()
    {
        string sentence = "I am loking for someone called: Nemo !";
        Console.WriteLine(FindNemo(sentence));

        string sentence2 = "I am not finding Nemo's tracks !";
        Console.WriteLine(FindNemo(sentence2));

        string sentence3 = "I did find Nemo even if Nemo didn't want it !";
        Console.WriteLine(FindNemo(sentence3));
    }

    public static string FindNemo(string sentence)
    {
        string[] words = sentence.Split(' ');
        int index = Array.IndexOf(words, "Nemo");
        if (index != -1)
        {
            return $"I found Nemo at {index + 1}!";
        }
        return "I can't find Nemo :(";
    }
}
