using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the range: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] fibonacci = new int[n];
        fibonacci[0] = 0;
        fibonacci[1] = 1;
        for (int i = 2; i < n; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }
        Console.WriteLine("Fibonacci Sequence (Non-Recursive):");
        foreach (int number in fibonacci)
        {
            Console.Write(number + " ");
        }
    }
}