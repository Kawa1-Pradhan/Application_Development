public class Calculator
{
    public void printWelcome()
    {
        Console.WriteLine("Welcome to the calculator");
    }

    public int add(int x, int y)
    {
        return x + y;
    }

    public int Multiply(int num1, int num2 = 1)  
    {
        return num1 * num2;
    }
}