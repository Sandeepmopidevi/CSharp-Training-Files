using System;

class Task3
{
    static void Main()
    {
        Console.Write("Enter a Double value: ");
        string input = Console.ReadLine();

        Double value = Double.Parse(input);

        Console.WriteLine("Double value entered: " + value);
    }
}