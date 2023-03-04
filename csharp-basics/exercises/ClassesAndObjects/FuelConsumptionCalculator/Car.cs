public class FuelGauge
{
    private int currentFuel;

    public FuelGauge()
    {
        currentFuel = 0;
    }

    public int GetCurrentFuel()
    {
        return currentFuel;
    }

    public void IncrementFuel()
    {
        if (currentFuel < 70)
        {
            currentFuel++;
        }
    }

    public void DecrementFuel()
    {
        if (currentFuel > 0)
        {
            currentFuel--;
        }
    }
}

public class Odometer
{
    private int currentMileage;
    private FuelGauge fuelGauge;

    public Odometer(FuelGauge fuelGauge)
    {
        currentMileage = 0;
        this.fuelGauge = fuelGauge;
    }

    public int GetCurrentMileage()
    {
        return currentMileage;
    }

    public void IncrementMileage()
    {
        currentMileage++;

        if (currentMileage > 999999)
        {
            currentMileage = 0;
        }

        if (currentMileage % 10 == 0)
        {
            fuelGauge.DecrementFuel();
        }
    }
}