﻿using System;
using System.ComponentModel;

class Program
{
    public static void Main(string[] args) // Capital 'M' in Main
    {
        //Task 1
        Task1 opt1 = new Task1();
        Console.WriteLine("Task 1");
        Console.WriteLine("\nAddition: " + opt1.Addition(3, 4));

        Console.WriteLine("Subtraction: " + opt1.Subtract(10, 4));
        Console.WriteLine("Multiplication: " + opt1.Multiply(2.5, 3));
        Console.WriteLine("Division: " + opt1.Divide(10, 2));

        opt1.OddEvenFinder(7);

        //Task 2
        Console.WriteLine("\nTask 2");

        NullOperators obj2 = new NullOperators();
        obj2.PerformNullChecks();

        //Task 3
        Console.WriteLine("\nTask 3");
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        AgeCheck obj3 = new AgeCheck();
        obj3.checkAge(age);

        //Task 4
        Console.WriteLine("\nTask 4");
        Day obj4 = new Day();

        Console.WriteLine("Enter the day number:");
        int num = Convert.ToInt32(Console.ReadLine());
        obj4.checkDay(age);

        //Task 5
        Console.WriteLine("\nTask 5");
        Loop obj5 = new Loop();
        Console.WriteLine("Enter your number to loop upto and sum");
        int num1 = Convert.ToInt32(Console.ReadLine());
        obj5.CalculateNsum(num1);

        Console.WriteLine("\nContinue and break while loop experiment");
        obj5.ContinueBreak();

        Console.WriteLine("\nSum of array");
        obj5.sumOfArray();

        //Task 6
        Console.WriteLine("\nTask 6");
        TryCatch obj6 = new TryCatch();
        obj6.FormatExcep();
        obj6.PasswordExcep();


    }
}