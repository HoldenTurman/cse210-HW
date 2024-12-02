using System;
public class Vehicle
{
    public virtual void StartEngine()
    {
        Console.WriteLine();
    }
}

class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("key");
    }
}

class Motorcycle : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("kick start");
    }
}
