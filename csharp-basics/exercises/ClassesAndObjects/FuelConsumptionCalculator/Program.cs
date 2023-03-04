using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter data for Car 1:");
            Console.Write("Start kilometers: ");
            double startKilometers1 = double.Parse(Console.ReadLine());
            Console.Write("End kilometers: ");
            double endKilometers1 = double.Parse(Console.ReadLine());
            Console.Write("Liters of gas used: ");
            double liters1 = double.Parse(Console.ReadLine());

            Car car1 = new Car(startKilometers1, endKilometers1, liters1);

            Console.WriteLine("Enter data for Car 2:");
            Console.Write("Start kilometers: ");
            double startKilometers2 = double.Parse(Console.ReadLine());
            Console.Write("End kilometers: ");
            double endKilometers2 = double.Parse(Console.ReadLine());
            Console.Write("Liters of gas used: ");
            double liters2 = double.Parse(Console.ReadLine());

            Car car2 = new Car(startKilometers2, endKilometers2, liters2);

            Console.WriteLine("Car 1 consumption: {0:F2} L/100km", car1.CalculateConsumption());
            Console.WriteLine("Car 2 consumption: {0:F2} L/100km", car2.CalculateConsumption());

            if (car1.GasHog())
            {
                Console.WriteLine("Car 1 is a gas hog");
            }
            else if (car1.EconomyCar())
            {
                Console.WriteLine("Car 1 is an economy car");
            }

            if (car2.GasHog())
            {
                Console.WriteLine("Car 2 is a gas hog");
            }
            else if (car2.EconomyCar())
            {
                Console.WriteLine("Car 2 is an economy car");
            }

            Console.WriteLine("Filling up Car 1...");
            car1.FillUp(10000, 50);
            Console.WriteLine("Car 1 new consumption: {0:F2} L/100km", car1.CalculateConsumption());
        }
    }
}