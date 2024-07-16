using System;

class Task2
{
    static void Main()
    {
        Console.Write("Enter the stock price: ");
        string input = Console.ReadLine();
        double stockPrice = double.Parse(input);
        float floatPrice = (float)(stockPrice);
        Console.WriteLine("Float price: "+floatPrice);
        long longPrice = (long)(stockPrice);
        Console.WriteLine("Long price: "+longPrice);
        int intPrice = (int)(stockPrice);
        Console.WriteLine("Int price: "+intPrice);
    }
}