using System;

public class task2
{
    public delegate int Calculate(int num1, int num2);

    public int Add(int a, int b) => a + b;

    public int Subtract(int a, int b) => a - b;
}
