using System;

class Program
{
    public delegate int Calculate(int num1, int num2);
    public delegate double DiscountStrategy(double price);

    static void Main(string[] args)
    {
        Console.WriteLine("==Rectangle task1==");

        task1 rect = new task1 { Length = 10, Breadth = 5 };

        Console.WriteLine(rect.ShowDetails);
        Console.WriteLine($"Area: {rect.GetArea()}");
        Console.WriteLine($"Perimeter: {rect.GetParameter()}");

        // ========= Task 2 ==========
        Console.WriteLine("\n== Task 2: Custom Delegate ==");

        task2 t2 = new task2();
        task2.Calculate cal;

        cal = t2.Add;
        Console.WriteLine("Addition: " + cal(10, 5));

        cal = t2.Subtract;
        Console.WriteLine("Subtraction: " + cal(10, 5));

        // ========= Task 2.1 ==========
        Console.WriteLine("\n== Task 2.1: Discount Strategy ==");

        task2_1 t21 = new task2_1();
        double price = 1000;

        Console.WriteLine("Festival Discount: " +
            t21.CalculateFinalPrice(price, t21.FestivalDiscount));

        Console.WriteLine("Seasonal Discount: " +
            t21.CalculateFinalPrice(price, t21.SeasonalDiscount));

        Console.WriteLine("No Discount: " +
            t21.CalculateFinalPrice(price, t21.NoDiscount));

        Console.WriteLine("30% Lambda Discount: " +
            t21.CalculateFinalPrice(price, p => p - (p * 0.30)));

            // ========= Task 3 ==========
        Console.WriteLine("\n== Task 3: Built-in Delegate (Func) ==");

        task3 t3 = new task3();
        int[] nums = { 2, 5, 12, 7, 20, 3, 11 };

        Console.WriteLine("Even Numbers:");
        t3.ProcessNumbers(nums, n => n % 2 == 0);

        Console.WriteLine("\nNumbers Greater Than 10:");
        t3.ProcessNumbers(nums, n => n > 10);

        Console.WriteLine("\n== Task 4: LINQ Basics ==");

        task4 t4 = new task4();

        t4.SquareNumbers();
        t4.FilterBooks();
        t4.SortStudents();

        // ========= Task 5 ==========
        Console.WriteLine("\n== Task 5: LINQ Continued ==");

        task5 t5 = new task5();

        Console.WriteLine("\n--- Aggregation Operators ---");
        t5.AggregationTask();

        Console.WriteLine("\n--- Quantifier Operators (Any / All) ---");
        t5.QuantifierTask();

        Console.WriteLine("\n--- Element Operators (First / Last / FirstOrDefault) ---");
        t5.ElementTask();
        // ========= Task 6 ==========
        Console.WriteLine("\n== Task 6: LINQ Advanced ==");

        task6 t6 = new task6();
        t6.GenerateReport();



    }
}
