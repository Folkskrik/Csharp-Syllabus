class Odometer
{
    private int mileage;
    private FuelGauge fuelGauge;

    public Odometer(FuelGauge fuelGauge)
    {
        mileage = 0;
        this.fuelGauge = fuelGauge;
    }

    public int GetMileage()
    {
        return mileage;
    }

    public void IncrementMileage()
    {
        if (mileage < 999999)
        {
            mileage++;
        }
        else
        {
            mileage = 0;
        }
        if (mileage % 10 == 0)
        {
            fuelGauge.DecrementFuel();
        }
    }
}