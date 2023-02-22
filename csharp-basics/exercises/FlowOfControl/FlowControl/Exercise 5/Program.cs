using System;

namespace PhoneKeyPad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to convert to phone keypad digits: ");
            string text = Console.ReadLine().ToLower();
            string result = "";

            // using nested-if statement
            foreach (char c in text)
            {
                if (c == 'a' || c == 'b' || c == 'c')
                {
                    result += "2";
                }
                else if (c == 'd' || c == 'e' || c == 'f')
                {
                    result += "3";
                }
                else if (c == 'g' || c == 'h' || c == 'i')
                {
                    result += "4";
                }
                else if (c == 'j' || c == 'k' || c == 'l')
                {
                    result += "5";
                }
                else if (c == 'm' || c == 'n' || c == 'o')
                {
                    result += "6";
                }
                else if (c == 'p' || c == 'q' || c == 'r' || c == 's')
                {
                    result += "7";
                }
                else if (c == 't' || c == 'u' || c == 'v')
                {
                    result += "8";
                }
                else if (c == 'w' || c == 'x' || c == 'y' || c == 'z')
                {
                    result += "9";
                }
            }

            Console.WriteLine("Phone keypad digits: " + result);

            // using switch-case statement
            result = "";
            foreach (char c in text)
            {
                switch (c)
                {
                    case 'a':
                    case 'b':
                    case 'c':
                        result += "2";
                        break;
                    case 'd':
                    case 'e':
                    case 'f':
                        result += "3";
                        break;
                    case 'g':
                    case 'h':
                    case 'i':
                        result += "4";
                        break;
                    case 'j':
                    case 'k':
                    case 'l':
                        result += "5";
                        break;
                    case 'm':
                    case 'n':
                    case 'o':
                        result += "6";
                        break;
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                        result += "7";
                        break;
                    case 't':
                    case 'u':
                    case 'v':
                        result += "8";
                        break;
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        result += "9";
                        break;
                    default:
                        result += c;
                        break;
                }
            }
            Console.WriteLine("Phone keypad digits: " + result);
        }
    }
}