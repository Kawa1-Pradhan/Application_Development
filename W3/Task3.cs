class AgeCheck
{
    public void checkAge(int  age)
    {
        if (age < 13)
        {
            Console.WriteLine("Child");
        }
        else if (age >= 13 && age <= 19 )
        {
            Console.WriteLine("Teenager");
        }
        else if ( age >= 20)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Invalid Age");
        }
    }
}