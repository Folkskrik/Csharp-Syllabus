using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            FuelGauge fuelGauge = new FuelGauge();
            Odometer odometer = new Odometer(fuelGauge);

            Console.WriteLine("Filling up the car...");
            for (int i = 0; i < 70; i++)
            {
                fuelGauge.IncrementFuel();
            }

            Console.WriteLine("Starting the journey...");
            while (fuelGauge.GetCurrentFuel() > 0)
            {
                odometer.IncrementMileage();

                Console.WriteLine("Current mileage: " + odometer.GetCurrentMileage() + " km");
                Console.WriteLine("Current fuel: " + fuelGauge.GetCurrentFuel() + " L");
                Console.WriteLine();
            }

            Console.WriteLine("The car has run out of fuel.");
            Console.ReadKey();
        }
    }
}