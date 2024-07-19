using System;
using System.Collections.Generic;

class Task5
{
    static void Main()
    {
        List<string> colors = new List<string>();
        Console.WriteLine("Enter colors for your palette (type 'done' to finish):");
        string input = Console.ReadLine();
        while (input != "done")
        {
            colors.Add(input);
            input = Console.ReadLine();
        }
        Console.WriteLine("Colors in forward order:");
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }
        Console.WriteLine("Colors in reverse order:");
        for (int i = colors.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(colors[i]);
        }
    }
}