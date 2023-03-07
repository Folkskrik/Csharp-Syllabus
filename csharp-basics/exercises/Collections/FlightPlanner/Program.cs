using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "C:\\Users\\aleks\\source\\repos\\CodeLex\\csharp-basics\\exercises\\Collections\\FlightPlanner\\flights.txt";
        private static Dictionary<string, List<string>> flights;

        static void Main(string[] args)
        {
            flights = new Dictionary<string, List<string>>();
            var readText = File.ReadAllLines(Path);
            foreach (var line in readText)
            {
                if (line.Trim().Length == 0)
                {
                    continue;
                }

                var cities = line.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(city => city.Trim());
                if (cities.Count() != 2)
                {
                    Console.WriteLine($"Invalid line format: {line}");
                    continue;
                }

                if (!flights.ContainsKey(cities.First()))
                {
                    flights[cities.First()] = new List<string>();
                }
                flights[cities.First()].Add(cities.Last());
            }

            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("To display the list of available cities, press 1");
                Console.WriteLine("To start planning a trip, press 2");
                Console.WriteLine("To exit the program, press 3");

                var choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Available cities:");
                    foreach (var city in flights.Keys)
                    {
                        Console.WriteLine(city);
                    }
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Enter the starting city:");
                    var startingCity = Console.ReadLine();
                    if (!flights.ContainsKey(startingCity))
                    {
                        Console.WriteLine("Invalid starting city.");
                        continue;
                    }

                    var route = new List<string>() { startingCity };
                    while (true)
                    {
                        Console.WriteLine($"From {route.Last()} you can fly directly to:");
                        var destinations = flights[route.Last()];
                        foreach (var destination in destinations)
                        {
                            Console.WriteLine(destination);
                        }

                        Console.WriteLine("Where would you like to go next?");
                        var nextCity = Console.ReadLine();
                        if (nextCity == startingCity)
                        {
                            if (route.Count > 1 && flights[route.Last()].Contains(startingCity))
                            {
                                route.Add(startingCity);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You have not completed a round-trip route.");
                            }
                        }
                        else if (flights[route.Last()].Contains(nextCity))
                        {
                            route.Add(nextCity);
                        }
                        else
                        {
                            Console.WriteLine($"You cannot get to {nextCity} from {route.Last()}.");
                        }
                    }

                    Console.WriteLine("Your chosen round-trip route is:");
                    Console.WriteLine(string.Join(" -> ", route));
                }
                else if (choice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }
    }
}