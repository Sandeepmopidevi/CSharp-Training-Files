using System;
public class DeviceFailureException : Exception
{
    public DeviceFailureException(string message) : base(message)
    {
    }
}
public class Task2
{
    static void Main(string[] args){
        try{
            Use(args[0]);
        }catch(DeviceFailureException e){
            Console.WriteLine(e.Message);
        }
    }
    public static void Use(string printerName)
    {
        if (printerName == "printer1" || printerName == "printer3")
        {
            Console.WriteLine("Available");
        }
        else
        {
            throw new DeviceFailureException("Device failure: Not Available");
        }
        }
    }
