using System;
using System.Collections.Generic;
using System.Linq;

namespace DecryptNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cryptedNumbers = new List<string>
            {
                "())(",
                "*$(#&",
                "!!!!!!!!!!",
                "$*^&@!",
                "!)(^&(#@",
                "!)(#&%(*@#%"
            };

            var decryptedNumbers = cryptedNumbers.Select(DecryptString);

            foreach (var decryptedNumber in decryptedNumbers)
            {
                Console.WriteLine(decryptedNumber);
            }
        }

        private static string DecryptString(string encryptedString)
        {
            var decryptionTable = new Dictionary<char, char>
            {
                { '!', '1' },
                { '@', '2' },
                { '#', '3' },
                { '$', '4' },
                { '%', '5' },
                { '^', '6' },
                { '&', '7' },
                { '*', '8' },
                { '(', '9' },
                { ')', '0' }
            };

            return new string(encryptedString.Select(c => decryptionTable.ContainsKey(c) ? decryptionTable[c] : c).ToArray());
        }
    }
}