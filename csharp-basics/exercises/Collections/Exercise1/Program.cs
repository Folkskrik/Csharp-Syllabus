using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            //todo - replace array with an List and print out the results

            List<string> list = new List<string>();
            list.AddRange(array);

            list.ForEach(Console.WriteLine);

            //todo - replace array with a HashSet and print out the results

            HashSet<string> set = new HashSet<string>(array);

            foreach (string brand in set)
            {
                Console.WriteLine(brand);
            }
        }
    }
}