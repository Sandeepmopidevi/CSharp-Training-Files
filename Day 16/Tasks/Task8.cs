using System;
using System.Collections.Generic;
class Task8
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements you want to add:");
        int count = Convert.ToInt32(Console.ReadLine());
        List<object> elements = new List<object>();
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < count; i++)
        {
            object element = Console.ReadLine();
            elements.Add(element);
        }
        Console.WriteLine("Elements in the list:");
        foreach (object element in elements)
        {
            Console.WriteLine(element);
        }
    }
}