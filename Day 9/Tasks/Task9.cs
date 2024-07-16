using System;
class Task9
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter an integer as a string:");
            string input = Console.ReadLine();

            int number = int.Parse(input);
            Console.WriteLine(number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: The input is not a valid integer.");
        }
    }
}