using DragRace;
using System;

public class Lexus : ICar, IBoostable
{
    private int _currentSpeed = 0;

    public void SpeedUp()
    {
        _currentSpeed += 8;
    }

    public void SlowDown()
    {
        _currentSpeed -= 8;
    }

    public string ShowCurrentSpeed()
    {
        return _currentSpeed.ToString();
    }

    public void UseBoost()
    {
        _currentSpeed += 10;
    }

    public void StartEngine()
    {
        Console.WriteLine("Rrrrrrr.....");
    }
}