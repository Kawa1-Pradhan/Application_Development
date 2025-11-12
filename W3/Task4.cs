class Day
{
    public void checkDay(int num)
    {
        switch (num)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;

            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 9:
                Console.WriteLine("Friday");
                break;
            case 10:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;

        }
    }
}