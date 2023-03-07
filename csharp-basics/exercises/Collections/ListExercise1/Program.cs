using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Red");
            list.Add("Blue");
            list.Add("Green");
            list.Add("Yellow");
            list.Add("White");

            foreach (var colours in list) 
            {
                Console.WriteLine(colours);
            }
        }
    }
}
