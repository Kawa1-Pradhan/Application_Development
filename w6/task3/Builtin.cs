using System;

public class task3
{
    public void ProcessNumbers(int[] numbers, Func<int, bool> condition)
    {
        foreach (var num in numbers)
        {
            if (condition(num))
            {
                Console.WriteLine(num);
            }
        }
    }
}
