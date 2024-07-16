using System;
public class InvalidAgeException : Exception
{
    public InvalidAgeException(string Message):base(Message)
    {
        
    }
}
class program
{
    static void Valid(int a)
    {
        if(a<18)
        {
            throw new InvalidAgeException("Not eligible for voting");
        }

    }
    static void Main(string[] args)
    
    {
        try
        {
            Valid(12);
        }
        catch(InvalidAgeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}