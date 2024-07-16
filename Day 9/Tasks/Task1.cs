using System;

sealed class Task1
{
    static void Main(string[] args)
    {
        double number = double.Parse(args[0]);
        Console.WriteLine("Command line args " + number);
        
        double finalNumber = number;
        Console.WriteLine("Final number is: " + finalNumber);
        
        double multipliedNumber = finalNumber * 2;
        Console.WriteLine("Final number multiplied with 2: " + multipliedNumber);
        
        double addedNumber = finalNumber + 4;
        Console.WriteLine("Final number added with 4: " + addedNumber);
    }
}