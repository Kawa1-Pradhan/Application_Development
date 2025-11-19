using System;


public class Program
{
    public static void Main(string[] args)
    {
        // Task 1
        Console.WriteLine("Task 1");

        // Student 1
        Student std1 = new Student();
        std1.name = "Kawal";
        std1.section = "L3C2";
        std1.age = 20;

        // Student 2
        Student std2 = new Student();
        std2.name = "Swastika";
        std2.section = "L3C2";
        std2.age = 21;

        // Printing
        Console.WriteLine("\nStudent 1 details:");
        Console.WriteLine($"Name: {std1.name}");
        Console.WriteLine($"Section: {std1.section}");
        Console.WriteLine($"Age: {std1.age}");
        Console.WriteLine($"College Name: {Student.schoolName}");

        Console.WriteLine("\nStudent 2 details:");
        Console.WriteLine($"Name: {std2.name}");
        Console.WriteLine($"Section: {std2.section}");
        Console.WriteLine($"Age: {std2.age}");
        Console.WriteLine($"College Name: {Student.schoolName}");


        //Task 2
        Console.WriteLine("\nTask 2");

        //welcome printer
        Console.WriteLine("\nWelcome printer");
        Calculator cal = new Calculator();
        cal.printWelcome();

        //add
        Console.WriteLine("\nAdding calculator");
        Console.WriteLine(cal.add(6, 7));

        //optional multiplication
        Console.WriteLine("\nMultiplying calculator");
        Console.WriteLine(cal.Multiply(6));


        //Task 3
        Console.WriteLine("\nTask 3");

        ParameterDemo demo = new ParameterDemo();

        // Call Increase with ref
        Console.WriteLine("\nIncrease number by 10");
        int myNumber = 5;
        demo.Increase(ref myNumber);
        Console.WriteLine("After Increase: " + myNumber);

        // Call GetFullName with out
        Console.WriteLine("\nGet name with out parameter");
        string fullName;
        demo.GetFullName(out fullName);
        Console.WriteLine("Full Name: " + fullName);

        // Call sum of all params
        Console.WriteLine("\nSum of all numbers");
        int sum = demo.SumAll(1, 2, 3, 4, 5);
        Console.WriteLine("Sum of all numbers: " + sum);


        //Task 4
        Console.WriteLine("\nTask 4");

        // Create object using default constructor
        Player player1 = new Player();
        Console.WriteLine("Name: " + player1.playerName);
        Console.WriteLine("Level: " + player1.level);
        Console.WriteLine("Health: " + player1.health);
        Console.WriteLine("Default Player Values:");

        // Create object using parameterized constructor
        Player paramPlayer = new Player("Rupen", 5, 100);
        Console.WriteLine("\nParameterized Player Values:");
        Console.WriteLine("Name: " + paramPlayer.playerName);
        Console.WriteLine("Level: " + paramPlayer.level);
        Console.WriteLine("Health: " + paramPlayer.health);

        //Task 5

        Console.WriteLine("\nTask 5");

        Console.Write("Enter a day: ");
        string dayInput = Console.ReadLine().Trim().ToLower();

        DataType dayType; 

        // Check weekend condition (Friday or Saturday)
        if (dayInput == "friday" || dayInput == "saturday")
        {
            dayType = DataType.Weekend;
        }
        else
        {
            dayType = DataType.Weekday;
        }

        Console.WriteLine("It is: " + dayType);
        Console.WriteLine();

        //Record 

        // Create first book object
        Book book1 = new Book("Clean Code", "Robert C. Martin", 999.99);

        // Create second book using WITH expression (change title & price)
        Book book2 = book1 with { title = "The Pragmatic Programmer", price = 799.99 };

        // Print first object
        Console.WriteLine("First Book:");
        Console.WriteLine($"Title: {book1.title}");
        Console.WriteLine($"Author: {book1.author}");
        Console.WriteLine($"Price: {book1.price}");

        // Deconstruct second object and adding variable
        var (title, author, price) = book2;

        Console.WriteLine("\nDeconstructed Second Book:");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);


        //Task 6
        Console.WriteLine("\nTask 6");

        int marks, total;

        // Taking input using TryParse
        Console.Write("Enter marks: ");
        bool marksValid = int.TryParse(Console.ReadLine(), out marks);

        Console.Write("Enter total marks: ");
        bool totalValid = int.TryParse(Console.ReadLine(), out total);

        // Validate input
        if (!marksValid || !totalValid)
        {
            Console.WriteLine("Invalid input! Please enter valid integers.");
            return;
        }


        // Correct calculation (floating-point division)
        double percentage = (double)marks / total * 100;

        //BREAKPOINT 2: Set here to see the correct calculated value
        Console.WriteLine("Percentage: " + percentage);


    }
}