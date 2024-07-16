using System;
public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {
    }
}
public class User
{
    public int Age;

    public User(int age)
    {
        if (age <= 0 || age > 100)
        {
            throw new InvalidAgeException("Age is not valid.");
        }

        Age = age;
    }
}
public class Task5
{
    public static void Main(string[] args)
    {
        try
        {
            int age = int.Parse(args[0]);
            User user = new User(age);
            Console.WriteLine("Valid age.");
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input.");
        }
    }
}