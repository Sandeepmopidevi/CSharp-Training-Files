using System;

class Task5
{
    static void Main()
    {
        Console.Write("Enter a short value: ");
        short shortValue = Convert.ToInt16(Console.ReadLine());
        char charValue = Convert.ToChar(shortValue);
        Console.WriteLine("Original short value: " + shortValue);
        Console.WriteLine("Converted char value: " + charValue);
    }
}