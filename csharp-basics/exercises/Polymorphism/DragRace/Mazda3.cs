using DragRace;
using System;

public class Mazda3 : ICar, IBoostable
{
    private int _currentSpeed = 0;

    public void SpeedUp()
    {
        _currentSpeed += 9;
    }

    public void SlowDown()
    {
        _currentSpeed -= 10;
    }

    public string ShowCurrentSpeed()
    {
        return _currentSpeed.ToString();
    }

    public void UseBoost()
    {
        _currentSpeed += 11;
    }

    public void StartEngine()
    {
        Console.WriteLine("Rrrrrrr.....");
    }
}