using DragRace;
using System;

public class Mazda3 : ICar, IBoostable
{
    private int currentSpeed = 0;

    public void SpeedUp()
    {
        currentSpeed += 9;
    }

    public void SlowDown()
    {
        currentSpeed -= 10;
    }

    public string ShowCurrentSpeed()
    {
        return currentSpeed.ToString();
    }

    public void UseBoost()
    {
        currentSpeed += 11;
    }
    public void StartEngine()
    {
        Console.WriteLine("Rrrrrrr.....");
    }
}