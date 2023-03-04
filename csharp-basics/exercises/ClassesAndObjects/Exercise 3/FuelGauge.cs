class FuelGauge
{
    private int fuel;

    public FuelGauge()
    {
        fuel = 0;
    }

    public int GetFuel()
    {
        return fuel;
    }

    public void IncrementFuel()
    {
        if (fuel < 70)
        {
            fuel++;
        }
    }

    public void DecrementFuel()
    {
        if (fuel > 0)
        {
            fuel--;
        }
    }
}

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