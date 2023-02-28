using System;
using System.CodeDom.Compiler;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, result;
            
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());

            result = 1;
            /*
            todo - complete loop to multiply i with itself n times, it is NOT allowed to use Math.Pow()
            */
            for (i = 0; i < n; i++)
            {
                result *= n;
            }
            Console.WriteLine(+ n + " mutliplyed by it self the same amout of times is " + result);
            Console.ReadKey();
        }
    }
}
