class TryCatch
{
    public void FormatExcep()
    {
        try
        {
            Console.Write("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number format");
        }
        finally
        {
            Console.WriteLine("Program Executed");
        }
    }

    public void PasswordExcep()
    {
        try
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (password.Length < 6)
            {
                throw new Exception("Password must be at least 6 characters.");
            }

            Console.WriteLine("Password satisfied the requirement.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}