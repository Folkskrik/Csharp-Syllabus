using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string[] names1 = { "mavis", "senaida", "letty" };
        string[] names2 = { "samuel", "MABELLE", "letitia", "meridith" };
        string[] names3 = { "Slyvia", "Kristal", "Sharilyn", "Calista" };

        string[] capNames1 = CapMe(names1);
        string[] capNames2 = CapMe(names2);
        string[] capNames3 = CapMe(names3);

        Console.WriteLine(string.Join(", ", capNames1));
        Console.WriteLine(string.Join(", ", capNames2));
        Console.WriteLine(string.Join(", ", capNames3));
    }
        public static string[] CapMe(string[] names)
    {
        return names.Select(name => char.ToUpper(name[0]) + name.Substring(1).ToLower()).ToArray();
    }
}
