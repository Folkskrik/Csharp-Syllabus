using DragRace;
using System;

public class Tesla : ICar
{
    private int _currentSpeed = 0;

    public void SpeedUp()
    {
        _currentSpeed += 11;
    }

    public void SlowDown()
    {
        _currentSpeed -= 7;
    }

    public string ShowCurrentSpeed()
    {
        return _currentSpeed.ToString();
    }

    public void StartEngine()
    {
        Console.WriteLine("-- silence ---");
    }
}