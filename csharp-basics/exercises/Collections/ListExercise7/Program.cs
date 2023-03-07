using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            if (colors.Contains("White"))
            {
                Console.WriteLine("The list contains the string element 'White'.");
            }
            else
            {
                Console.WriteLine("The list does not contain the string element 'White'.");
            }
        }
    }
}
