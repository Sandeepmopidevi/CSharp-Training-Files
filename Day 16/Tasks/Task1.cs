using System;
using System.Collections.Generic;
class Task1
{
    static void Main()
    {
        List<string> fruits = new List<string>();
        while (true)
        {
            Console.WriteLine("Enter a fruit (or 'x' to exit):");
            string input = Console.ReadLine();

            if (input.ToLower() == "x")
                break;
            fruits.Add(input);
        }
        Console.WriteLine("List of fruits entered:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}