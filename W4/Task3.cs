using System;

public class ParameterDemo
{
    //Method using ref to increase the number
    public void Increase(ref int number)
    {
        number += 10;
    }

    //Method using out to assign full name
    public void GetFullName(out string fullname)
    {
        fullname = "Kawal Pradhan"; 
    }
     
    //Method using params to sum all numbers
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}