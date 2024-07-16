using System;

class Task7
{
    static void Main()
    {
        Console.Write("Enter the range: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci Sequence (Recursive):");
        for (int i = 0; i < n; i++)
        {
            Console.Write(FibonacciRecursive(i) + " ");
        }
    }
    static int FibonacciRecursive(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
}