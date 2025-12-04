using System;
using System.Collections.Generic;
using System.Linq;

public class Book
{
    public string Title { get; set; }
    public double Price { get; set; }
}

public class Student
{
    public string Name { get; set; }
}

public class task4
{
    public void SquareNumbers()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        var squared = numbers.Select(n => n * n).ToList();

        Console.WriteLine("Squared Numbers:");
        foreach (var s in squared)
        {
            Console.WriteLine(s);
        }
    }

    public void FilterBooks()
    {
        List<Book> books = new List<Book>
        {
            new Book { Title = "Book A", Price = 500 },
            new Book { Title = "Book B", Price = 1500 },
            new Book { Title = "Book C", Price = 2200 }
        };

        var premiumBooks = books.Where(b => b.Price > 1000).ToList();

        Console.WriteLine("\nBooks Priced Above 1000:");
        foreach (var book in premiumBooks)
        {
            Console.WriteLine($"{book.Title} - Rs.{book.Price}");
        }
    }

    public void SortStudents()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Kamal" },
            new Student { Name = "Sita" },
            new Student { Name = "Ram" },
            new Student { Name = "Bimal" }
        };

        var sorted = students.OrderBy(s => s.Name).ToList();

        Console.WriteLine("\nSorted Students Alphabetically:");
        foreach (var s in sorted)
        {
            Console.WriteLine(s.Name);
        }
    }
}
