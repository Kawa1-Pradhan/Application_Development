using System;
using System.Collections.Generic;

class Circle
{
    public const double pi = 3.14;
}

class Program
{
    

    // 🧩 Task 1
    static void Task1()
    {
        string userName = "Kawal";
        int luckyNumber = 7;
        Console.WriteLine($"\nTask 1 Output:");
        Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");
    }

    // 🧩 Task 2
    static void Task2()
    {
        Console.WriteLine($"\nTask 2 Output:");

        double radius = 5;
        double area = radius * radius * Circle.pi;
        double perimeter = 2 * radius * Circle.pi;

        Console.WriteLine($"Area of Circle with radius {radius}: {area}");
        Console.WriteLine($"Perimeter of Circle with radius {radius}: {perimeter}");
    }

    // 🧩 Task 3
    static void Task3()
    {
        Console.WriteLine($"\nTask 3 Output:");

        byte a = 10;
        short b = 200;
        int c = 3000;
        long d = 40000L;
        float e = 5.5f;
        double f = 10.99;
        decimal g = 100.55m;
        char h = 'A';
        bool i = true;

        string numberAsString = c.ToString();
        double stringToDouble = Convert.ToDouble("3.14");

        Console.WriteLine($"byte: {a}");
        Console.WriteLine($"short: {b}");
        Console.WriteLine($"int: {c}");
        Console.WriteLine($"long: {d}");
        Console.WriteLine($"float: {e}");
        Console.WriteLine($"double: {f}");
        Console.WriteLine($"decimal: {g}");
        Console.WriteLine($"char: {h}");
        Console.WriteLine($"bool: {i}");
        Console.WriteLine($"int to string: {numberAsString}");
        Console.WriteLine($"string to double: {stringToDouble}");
    }

    // 🧩 Task 4
    static void Task4()
    {
        Console.WriteLine($"\nTask 4 Output:");

        int[] num = { 8, 9, 3, 1, 5, 2 };

        Array.Sort(num);
        Console.WriteLine("Sorted numbers:");
        foreach (int n in num) Console.WriteLine(n);

        Array.Reverse(num);
        Console.WriteLine("\nReversed numbers:");
        foreach (int n in num) Console.WriteLine(n);

        int number = 2;
        int index = Array.IndexOf(num, number);
        if (index != -1)
            Console.WriteLine($"\nThe number {number} is available at index {index}");
        else
            Console.WriteLine($"The number {number} is not available in the array");
    }

    // 🧩 Task 5
    static void Task5()
    {
        Console.WriteLine($"\nTask 5 Output:");

        DateTime birthDate = new DateTime(2004, 5, 12);
        DateTime currentDate = DateTime.Now;

        TimeSpan ageSpan = currentDate - birthDate;
        int ageYears = (int)(ageSpan.Days / 365.25);

        Console.WriteLine($"Birthdate: {birthDate}");
        Console.WriteLine($"Current Date: {currentDate}");
        Console.WriteLine($"Your age is: {ageYears} years");

        DateTime addedDays = birthDate.AddDays(10);
        Console.WriteLine($"10 days after your birthdate: {addedDays}");
    }

    // 🧩 Task 6
    static void Task6()
    {
        Console.WriteLine($"\nTask 6 Output:");

        List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };
        fruits.Add("Orange");
        fruits.Remove("Banana");

        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits) Console.WriteLine(fruit);

        Dictionary<int, string> fruitDict = new Dictionary<int, string>
        {
            {1, "Apple"},
            {2, "Mango"},
            {3, "Orange"}
        };
        fruitDict.Add(4, "Grapes");

        Console.WriteLine("\nFruit Dictionary:");
        foreach (var item in fruitDict)
            Console.WriteLine($"ID: {item.Key}, Name: {item.Value}");
    }


    static void Main()
    {
        
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
    }
}
