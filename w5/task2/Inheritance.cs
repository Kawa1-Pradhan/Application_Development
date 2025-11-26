
public class Vehicle
{
    public string Brand { get; set; }
    public string Speed { get; set; }

    public void Start()  {
        Console.WriteLine("Vehicle started");
    }
    public void Stop() {
        Console.WriteLine("Vehicle stopped");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Speed: " + Speed);
    }
}

public class Car : Vehicle
{
    public int Seats { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Seats: " + Seats);
    }
}

public class Motorcycle : Vehicle
{
    public bool CanRun { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Can Run: " + CanRun);
    }
}
