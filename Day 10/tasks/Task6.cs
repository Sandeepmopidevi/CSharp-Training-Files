using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter the value of a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of b:");
            int b = int.Parse(Console.ReadLine());

            int result = a/b;
            Console.WriteLine("Result of a/b: "+result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Input Mismatch Exception: Please enter valid integer values.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Arithmetic Exception: Division by zero is not allowed.");
        }
        finally{
            Console.WriteLine("Finally Block Executed");
        }
    }
}