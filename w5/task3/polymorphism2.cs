using System;
// Task4.cs - Teacher classes and abstract vehicle classes

// Teacher + subclasses
public class Teacher
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }

    public void SalaryInfo()
    {
        Console.WriteLine("Salary is confidential.");
    }
}

public class NepaliTeacher : Teacher
{
    public override void Teaching()
    {
        Console.WriteLine("Nepali Teacher teaches in Nepali");
    }
}

public class EnglishTeacher : Teacher
{
    // inherits Teaching() from base (uses English)
}