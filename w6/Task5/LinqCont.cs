using System;
using System.Collections.Generic;
using System.Linq;

public class CashierSales
{
    public string CashierName { get; set; }
    public double Sales { get; set; }
}

public class Applicant
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Music
{
    public string Title { get; set; }
    public int DurationInSeconds { get; set; }
}

public class task5
{
    public void AggregationTask()
    {
        List<CashierSales> sales = new List<CashierSales>
        {
            new CashierSales { CashierName = "A", Sales = 5000 },
            new CashierSales { CashierName = "B", Sales = 8200 },
            new CashierSales { CashierName = "C", Sales = 3000 }
        };

        int totalCashiers = sales.Count();
        double totalSales = sales.Sum(s => s.Sales);
        double highest = sales.Max(s => s.Sales);
        double lowest = sales.Min(s => s.Sales);
        double average = sales.Average(s => s.Sales);

        Console.WriteLine("Total Cashiers: " + totalCashiers);
        Console.WriteLine("Total Sales: " + totalSales);
        Console.WriteLine("Highest Sales: " + highest);
        Console.WriteLine("Lowest Sales: " + lowest);
        Console.WriteLine("Average Sales: " + average);
    }

    public void QuantifierTask()
    {
        List<Applicant> applicants = new List<Applicant>
        {
            new Applicant { Name = "Rakesh", Age = 17 },
            new Applicant { Name = "Suresh", Age = 19 },
            new Applicant { Name = "Kamal", Age = 22 }
        };

        bool anyUnder18 = applicants.Any(a => a.Age < 18);
        bool allAbove16 = applicants.All(a => a.Age > 16);

        Console.WriteLine("\nAny applicant under 18: " + anyUnder18);
        Console.WriteLine("All applicants above 16: " + allAbove16);
    }

    public void ElementTask()
    {
        List<Music> songs = new List<Music>
        {
            new Music { Title = "Song A", DurationInSeconds = 180 },
            new Music { Title = "Song B", DurationInSeconds = 240 },
            new Music { Title = "Song C", DurationInSeconds = 300 },
            new Music { Title = "Song D", DurationInSeconds = 500 }
        };

        var firstSong = songs.First();
        var lastSong = songs.Last();
        var firstAbove4Min = songs.First(s => s.DurationInSeconds > 240);
        var safeLongSong = songs.FirstOrDefault(s => s.DurationInSeconds > 600);

        Console.WriteLine("\nFirst Song: " + firstSong.Title);
        Console.WriteLine("Last Song: " + lastSong.Title);
        Console.WriteLine("First Song Above 4 Minutes: " + firstAbove4Min.Title);

        Console.WriteLine("First Song Longer Than 10 Minutes: " +
            (safeLongSong != null ? safeLongSong.Title : "No such song"));
    }
}
