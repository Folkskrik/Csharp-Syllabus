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

            //todo - replace array with a Dictionary (use brand as key and origination as value) and print out the results

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            foreach (string brand in array)
            {
                switch (brand)
                {
                    case "Audi":
                        dictionary.Add(brand, "Germany");
                        break;
                    case "BMW":
                        dictionary.Add(brand, "Germany");
                        break;
                    case "Honda":
                        dictionary.Add(brand, "Japan");
                        break;
                    case "Mercedes":
                        dictionary.Add(brand, "Germany");
                        break;
                    case "VolksWagen":
                        dictionary.Add(brand, "Germany");
                        break;
                    case "Tesla":
                        dictionary.Add(brand, "USA");
                        break;
                }
            }
            foreach (KeyValuePair<string, string> kvp in dictionary)
            {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }
        }
    }
}