using System;
using System.Linq;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };
            var modifiedWords = words.Select(w => w.Replace("ea", "*"));
            foreach (var word in modifiedWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
