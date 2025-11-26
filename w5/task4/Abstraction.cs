using System;

// Abstract vehicle and implementations
public abstract class VehicleA
{
    public abstract void StartEngine();
    public abstract void StopEngine();

    public void Display()
    {
        Console.WriteLine("This is a vehicle");
    }
}

public class Cars : VehicleA
{
    public override void StartEngine() {
        Console.WriteLine("Car engine started");
    }
    public override void StopEngine()
    {
      Console.WriteLine("Car engine stopped"); 
    } 
}

public class Bike : VehicleA
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started");
    } 
    public override void StopEngine()
    {
        Console.WriteLine("Bike engine stopped");
    } 
}