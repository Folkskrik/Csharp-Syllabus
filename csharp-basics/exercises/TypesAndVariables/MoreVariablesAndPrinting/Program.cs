using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, Eyes, Teeth, Hair;
            int Age;

            Name = "Zed A. Shaw";
            Age = 35;
            double Height = 74.00 * 2.54;  // inches
            double Weight = 180.00 * 0.45; // lbs
            Eyes = "Blue";
            Teeth = "White";
            Hair = "Brown";

            Console.WriteLine("Let's talk about " + Name + ".");
            Console.WriteLine("He's " + Height + " inches tall.");
            Console.WriteLine("He's " + Weight + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + Eyes + " eyes and " + Hair + " hair.");
            Console.WriteLine("His teeth are usually " + Teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + Age + ", " + Height + ", and " + Weight
                               + " I get " + (Age + Height + Weight) + ".");

            Console.ReadKey();
        }
    }
}