using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file path:");
            string filePath = Console.ReadLine();

            int lineCount = 0;
            int wordCount = 0;
            int charCount = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lineCount++;

                    charCount += line.Length;

                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    wordCount += words.Length;

                    foreach (string word in words)
                    {
                        charCount += word.Count(c => char.IsLetterOrDigit(c));
                    }
                }
            }

            Console.WriteLine("Lines = {0}", lineCount);
            Console.WriteLine("Words = {0}", wordCount);
            Console.WriteLine("Chars = {0}", charCount);
        }
    }
}