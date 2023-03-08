using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        static void Main()
        {
            Car car1 = GetCarDataFromUser("Car 1");
            Car car2 = GetCarDataFromUser("Car 2");

            PrintCarConsumption(car1, "Car 1");
            PrintCarConsumption(car2, "Car 2");

            CheckGasHogOrEconomyCar(car1, "Car 1");
            CheckGasHogOrEconomyCar(car2, "Car 2");

            FillUpCar(car1);
            PrintCarConsumption(car1, "Car 1");
        }

        static Car GetCarDataFromUser(string carName)
        {
            Console.WriteLine($"Enter data for {carName}:");
            Console.Write("Start kilometers: ");
            double startKilometers = double.Parse(Console.ReadLine());

            Console.Write("End kilometers: ");
            double endKilometers = double.Parse(Console.ReadLine());

            Console.Write("Liters of gas used: ");
            double liters = double.Parse(Console.ReadLine());

            return new Car(startKilometers, endKilometers, liters);
        }

        static void PrintCarConsumption(Car car, string carName)
        {
            Console.WriteLine($"{carName} consumption: {car.CalculateConsumption():F2} L/100km");
        }

        static void CheckGasHogOrEconomyCar(Car car, string carName)
        {
            if (car.GasHog())
            {
                Console.WriteLine($"{carName} is a gas hog");
            }
            else if (car.EconomyCar())
            {
                Console.WriteLine($"{carName} is an economy car");
            }
        }

        static void FillUpCar(Car car)
        {
            Console.WriteLine("Filling up Car...");
            Console.Write("New odometer reading: ");
            double odometerReading = double.Parse(Console.ReadLine());

            Console.Write("Liters of gas used: ");
            double liters = double.Parse(Console.ReadLine());

            car.FillUp((int)odometerReading, liters);
        }
    }
}