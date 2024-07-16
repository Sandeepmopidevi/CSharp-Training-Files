using System;

class Task4
{
    static void Main(string[] args)
    {
        Console.Write("Enter a double value: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Original Value before Casting: " + price);
        short roundedShort = (short)Math.Round(price * 100);
        Console.WriteLine("After Type Casting to short: " + roundedShort);
        int roundedInt = (int)Math.Round(price * 100);
        Console.WriteLine("After Type Casting to int: " + roundedInt);
    }
}