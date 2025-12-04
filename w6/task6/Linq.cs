using System;
using System.Collections.Generic;
using System.Linq;

public class Tour
{
    public string CustomerName { get; set; }
    public string Destination { get; set; }
    public double Price { get; set; }
    public int DurationInDay { get; set; }
    public bool IsInternational { get; set; }
}

public class TourSummary
{
    public string CustomerName { get; set; }
    public string Destination { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
}

public class task6
{
    public void GenerateReport()
    {
        List<Tour> tours = new List<Tour>
        {
            new Tour { CustomerName = "Aayush", Destination = "Paris", Price = 50000, DurationInDay = 7, IsInternational = true },
            new Tour { CustomerName = "Rita", Destination = "Pokhara", Price = 8000, DurationInDay = 3, IsInternational = false },
            new Tour { CustomerName = "Suman", Destination = "Singapore", Price = 30000, DurationInDay = 5, IsInternational = true },
            new Tour { CustomerName = "Bikash", Destination = "Chitwan", Price = 12000, DurationInDay = 6, IsInternational = false }
        };

        // Step 1: Filtering
        var filteredTours = tours
            .Where(t => t.Price > 10000 && t.DurationInDay > 4)
            .ToList();

        // Step 2: Projection (Select new list)
        var projected = filteredTours
            .Select(t => new TourSummary
            {
                CustomerName = t.CustomerName,
                Destination = t.Destination,
                Category = t.IsInternational ? "International" : "Domestic",
                Price = t.Price
            })
            .ToList();

        // Step 3: Sorting (Domestic first, then International) & then by price
        var sorted = projected
            .OrderBy(t => t.Category) // Domestic before International
            .ThenBy(t => t.Price)
            .ToList();

        // Step 4: Display clean output
        Console.WriteLine("Tour Summary Report:");
        foreach (var item in sorted)
        {
            Console.WriteLine($"Customer: {item.CustomerName}, Destination: {item.Destination}, Category: {item.Category}, Price: Rs.{item.Price}");
        }
    }
}
