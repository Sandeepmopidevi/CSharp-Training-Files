using System;

public class Task4
{
    static void Main(string[] args)
    {
        int x = int.Parse(args[0]);
        int y = int.Parse(args[1]);
        double z = double.Parse(args[2]);
        const int constant1 = 45;
        const double constant2 = 3.14;
        double result = x * y + constant1 + constant2 * z;
        Console.WriteLine("The result is " + result);
    }
}