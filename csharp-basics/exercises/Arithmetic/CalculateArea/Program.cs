using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 0;

            while (userChoice != 4)
            {
                DisplayMenu();
                userChoice = GetChoice();

                switch (userChoice)
                {
                    case 1:
                        CalculateCircleArea();
                        break;
                    case 2:
                        CalculateRectangleArea();
                        break;
                    case 3:
                        CalculateTriangleArea();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
                public static void DisplayMenu()
        {
            Console.WriteLine("Geometry Calculator:");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit");
        }
        public static int GetChoice()
        {
            Console.Write("Enter your choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static void CalculateCircleArea()
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("The area of the circle is: " + area);
        }
        public static void CalculateRectangleArea()
        {
            Console.Write("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());
            double area = length * width;
            Console.WriteLine("The area of the rectangle is: " + area);
        }
        public static void CalculateTriangleArea()
        {
            Console.Write("Enter the base of the triangle: ");
            double ground = double.Parse(Console.ReadLine());
            Console.Write("Enter the height of the triangle: ");
            double height = double.Parse(Console.ReadLine());
            double area = 0.5 * ground * height;
            Console.WriteLine("The area of the triangle is: " + area);
        }
    }
}
