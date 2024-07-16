using System;

public class Vehicle
{
    public sealed void StartEngine(string vehicleType)
    {
        Console.WriteLine("The "+vehicleType+" engine starts.");
    }
}
public class Task2
{
    public static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle();
        vehicle.StartEngine(args[0]);
    }
}
