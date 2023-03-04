namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double startKilometers;
        private double endKilometers;
        private double liters;

        public Car(double startKilometers, double endKilometers, double liters)
        {
            this.startKilometers = startKilometers;
            this.endKilometers = endKilometers;
            this.liters = liters;
        }

        public double CalculateConsumption()
        {
            return 100 * this.liters / (this.endKilometers - this.startKilometers);
        }

        public bool GasHog()
        {
            return this.CalculateConsumption() > 15.0;
        }

        public bool EconomyCar()
        {
            return this.CalculateConsumption() < 5.0;
        }

        public void FillUp(int mileage, double liters)
        {
            this.startKilometers = this.endKilometers;
            this.endKilometers = mileage;
            this.liters = liters;
        }
    }
}