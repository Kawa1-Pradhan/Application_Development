class Task1
{
    public int Addition(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        return a / b;
    }

    public void OddEvenFinder(int num)
    {
        string result = (num % 2) == 0 ? "Even Number" : "Odd Number";
        Console.WriteLine(result);
    }
}