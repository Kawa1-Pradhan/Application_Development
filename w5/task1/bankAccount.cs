using System;

public class BankAccount
{
    private double balance;
    private int accountNumber = 12345;

    public int AccountNumber{
        get{return accountNumber;}

    }

    public double Balance
    {
       get{return balance;}
       private set
        {
            if (value > 0)
                balance = value;
            else 
                Console.WriteLine("Balance cannot be zero or negative");
        } 
    }

   
public void Deposit(double amount)
    {
        if (amount > 0)
            Balance += amount;
        else
            System.Console.WriteLine("Invalid deposit amount");
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
            Balance -= amount;
        else
            System.Console.WriteLine("Invalid withdraw amount or insufficient funds");
    }
} 