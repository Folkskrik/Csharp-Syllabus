class FuelGauge
{
    private int _fuel;

    public FuelGauge()
    {
        _fuel = 0;
    }

    public int GetFuel()
    {
        return _fuel;
    }

    public void IncrementFuel()
    {
        if (_fuel < 70)
        {
            _fuel++;
        }
    }

    public void DecrementFuel()
    {
        if (_fuel > 0)
        {
            _fuel--;
        }
    }
}