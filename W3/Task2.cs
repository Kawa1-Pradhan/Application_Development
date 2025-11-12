class NullOperators
{
    public void PerformNullChecks()
    {
        String username = null;

        String result = (username == null) ? "Username is not available" : username;
        Console.WriteLine(result);

        String result2 = username ?? "Username is not available";
        Console.WriteLine(result2);

        username ??= "kawal";
        Console.WriteLine(username);
    }

}