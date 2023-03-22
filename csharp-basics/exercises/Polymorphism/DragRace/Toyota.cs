using DragRace;
using System;

public class Toyota : ICar
{
    private int _currentSpeed = 0;

    public void SpeedUp()
    {
        _currentSpeed += 7;
    }

    public void SlowDown()
    {
        _currentSpeed -= 8;
    }

    public string ShowCurrentSpeed()
    {
        return _currentSpeed.ToString();
    }

    public void StartEngine()
    {
        Console.WriteLine("Rrrrrrr.....");
    }
}