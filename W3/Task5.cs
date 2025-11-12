class Loop
{
    public void CalculateNsum (int num)
    {
        int sum = 0;
        for (int i = 0; i <= num; i++)
        {
            sum = sum + i;
        }

        Console.WriteLine (sum);

    }

    public void ContinueBreak()
    {
        int i = 1;
        while (i <= 20)
        {
            i++;
            if (i % 4 == 0)
            {
                continue;
            }

            if (i == 15)
            {
                break;
            }

            Console.WriteLine(i);
        }
    }

    public void sumOfArray()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, };

        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine(sum);
    }


}