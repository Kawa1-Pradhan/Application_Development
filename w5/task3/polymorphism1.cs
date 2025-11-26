using System;
// Task3.cs - Printer (method overloading)
public class Printer
{
    public void Print(string message)
    {
        Console.WriteLine(message);
    }

    public void Print(int number)
    {
        Console.WriteLine(number);
    }

    public void Print(string message, int count)
    {
        for (int i = 0; i < count; i++)
            Console.WriteLine(message);
    }
}
