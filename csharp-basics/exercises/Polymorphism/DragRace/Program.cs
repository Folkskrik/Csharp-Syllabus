using System;
using System.Collections.Generic;

namespace DragRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICar> cars = new List<ICar>
            {
                new Audi(),
                new Bmw(),
                new Lexus(),
                new Mazda3(),
                new Tesla(),
                new Toyota()
            };

            for (int i = 0; i < 10; i++)
            {
                foreach (ICar car in cars)
                {
                    if (i == 2 && car is IBoostable boost)
                    {
                        boost.UseBoost();
                    }
                    else
                    {
                        car.SpeedUp();
                    }
                }
            }

            ICar fastestCar = null;
            int maxSpeed = int.MinValue;
            foreach (ICar car in cars)
            {
                int speed = int.Parse(car.ShowCurrentSpeed());
                if (speed > maxSpeed)
                {
                    maxSpeed = speed;
                    fastestCar = car;
                }
            }
            foreach (ICar car in cars)
            {
                Console.WriteLine($"{car.GetType().Name} speed: {car.ShowCurrentSpeed()}");
            }

            Console.WriteLine($"The fastest car is {fastestCar.GetType().Name} with a speed of {fastestCar.ShowCurrentSpeed()}.");
        }
    }
}