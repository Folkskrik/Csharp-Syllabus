FuelGauge fuelGauge = new FuelGauge();
Odometer odometer = new Odometer(fuelGauge);

while (fuelGauge.GetFuel() < 70)
{
    fuelGauge.IncrementFuel();
}

while (fuelGauge.GetFuel() > 0)
{
    odometer.IncrementMileage();
    Console.WriteLine("Mileage: " + odometer.GetMileage() + " km");
    Console.WriteLine("Fuel: " + fuelGauge.GetFuel() + " L");
}

Console.WriteLine("The car is out of fuel.");