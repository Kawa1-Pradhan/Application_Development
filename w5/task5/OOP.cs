// Task5.cs - ElectronicDevice, Laptop, Smartphone, ElectronicsStore
using System.Collections.Generic;

public abstract class ElectronicDevice
{
    public string Brand { get; set; }
    public double Price { get; set; }

    public ElectronicDevice(string brand, double price)
    {
        Brand = brand;
        Price = price;
    }

    public abstract void ShowInfo();
}

public class Laptop : ElectronicDevice
{
    public Laptop(string brand, double price) : base(brand, price) { }

    public override void ShowInfo()
    {
        Console.WriteLine("Laptop Brand: " + Brand + ", Price: " + Price);
    }

    public void TurnOnBattery()
    {
       Console.WriteLine("Laptop battery turned on");
    }
}

public class Smartphone : ElectronicDevice
{
    public Smartphone(string brand, double price) : base(brand, price) { }

    public override void ShowInfo()
    {
       Console.WriteLine("Smartphone Brand: " + Brand + ", Price: " + Price);
    }

    public void EnableCamera()
    {
        Console.WriteLine("Smartphone camera enabled");
    }
}

public class ElectronicsStore
{
    private List<ElectronicDevice> devices = new List<ElectronicDevice>();

    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
    }

    public void ShowAllDeviceDetails()
    {
        foreach (var d in devices)
        {
            d.ShowInfo();

            if (d is Laptop l)
                l.TurnOnBattery();

            if (d is Smartphone s)
                s.EnableCamera();

            Console.WriteLine();
        }
    }
}
