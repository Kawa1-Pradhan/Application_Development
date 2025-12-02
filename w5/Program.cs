using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Task 1: Bank Account ===");
        BankAccount account = new BankAccount();
        Console.WriteLine($"Account Number: {account.AccountNumber}");
        account.Deposit(500);
        Console.WriteLine($"Balance after deposit: {account.Balance}");
        account.Withdraw(200);
        Console.WriteLine($"Balance after withdrawal: {account.Balance}");
        account.Withdraw(500); // invalid withdraw

        Console.WriteLine("\n=== Task 2: Vehicle Classes ===");
        Car car = new Car { Brand = "Toyota", Speed = "120 km/h", Seats = 4 };
        Motorcycle bike = new Motorcycle { Brand = "Honda", Speed = "100 km/h", CanRun = true };

        car.Start();
        car.DisplayInfo();
        car.Stop();

        bike.Start();
        bike.DisplayInfo();
        bike.Stop();

        Console.WriteLine("\n=== Task 3: Printer (Method Overloading) ===");
        Printer printer = new Printer();
        printer.Print("Hello, World!");
        printer.Print(123);
        printer.Print("Repeated message", 3);

        Console.WriteLine("\n=== Task 4: Teacher Classes ===");
        Teacher teacher1 = new Teacher { Name = "Mr. Smith" };
        NepaliTeacher teacher2 = new NepaliTeacher { Name = "Ram" };
        EnglishTeacher teacher3 = new EnglishTeacher { Name = "John" };

        teacher1.Teaching();
        teacher2.Teaching();
        teacher3.Teaching();
        teacher1.SalaryInfo();

        Console.WriteLine("\n=== Task 4: Abstract VehicleA Classes ===");
        VehicleA myCar = new Cars();
        VehicleA myBike = new Bike();

        myCar.Display();
        myCar.StartEngine();
        myCar.StopEngine();

        myBike.Display();
        myBike.StartEngine();
        myBike.StopEngine();

        Console.WriteLine("\n=== Task 5: Electronics Store ===");
        ElectronicsStore store = new ElectronicsStore();
        Laptop laptop = new Laptop("Dell", 1200);
        Smartphone phone = new Smartphone("Samsung", 800);

        store.AddDevice(laptop);
        store.AddDevice(phone);

        store.ShowAllDeviceDetails();

        Console.WriteLine("\n=== Program Finished ===");
    }
}
