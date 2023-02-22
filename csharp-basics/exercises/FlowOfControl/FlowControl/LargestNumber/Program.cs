using System;
using System.Globalization;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Console.ReadLine();

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Console.ReadLine();

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Console.ReadLine();

            int num1, num2, num3;
            bool isNum1 = int.TryParse(input1, out num1);
            bool isNum2 = int.TryParse(input2, out num2);
            bool isNum3 = int.TryParse(input3, out num3);

            if (isNum1 && isNum2 && isNum3)
            {
                int largestNumber = Math.Max(num1, Math.Max(num2, num3));
                Console.WriteLine("The largest number is: " + largestNumber);
            }
            else
            {
                Console.WriteLine("Invalvid input, please enter 3 valid intigers");
            }
         }
    }
}
