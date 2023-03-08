using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory phoneDirectory = new PhoneDirectory();

            phoneDirectory.PutNumber("Anakin", "21234567");
            phoneDirectory.PutNumber("Obi-Wan", "23456789");
            phoneDirectory.PutNumber("Yoda", "23456789");

            Console.WriteLine("Phone numbers:");
            Console.WriteLine("Anakin: {0}", phoneDirectory.GetNumber("Anakin"));
            Console.WriteLine("Obi-Wan: {0}", phoneDirectory.GetNumber("Obi-Wan"));
            Console.WriteLine("Yoda: {0}", phoneDirectory.GetNumber("Yoda"));

            Console.ReadKey();
        }
    }
}