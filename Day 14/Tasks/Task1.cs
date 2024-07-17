using System;
using System.Collections.Generic;
public class Task1
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> evenNum = new List<int>();
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNum.Add(number);
            }
        }
        Console.WriteLine("Even numbers:");
        foreach (int number in evenNum)
        {
            Console.WriteLine(number);
        }
    }
}