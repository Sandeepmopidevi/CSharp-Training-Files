using System;
using System.Collections;

class T1
{
    static void Main(string[] args)
    {
        ArrayList l1 = new ArrayList() { 12, 23, 45, 67, 89 };
        // Accessing elements
        Console.WriteLine("Accessing elements:");
        Console.WriteLine("First element: " + l1[0]);
        Console.WriteLine("Last element: " + l1[l1.Count - 1]);
        Console.WriteLine();
        // Searching
        Console.WriteLine("Searching:");
        int index = l1.IndexOf(45);
        if (index != -1)
        {
            Console.WriteLine("Element 45 found at index: " + index);
        }
        else
        {
            Console.WriteLine("Element 45 not found");
        }
        Console.WriteLine();
        // Sorting
        Console.WriteLine("Sorting:");
        l1.Sort();
        foreach (var num in l1)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();
        // Inserting
        Console.WriteLine("Inserting:");
        l1.Insert(2, 34); // Insert 34 at index 2
        foreach (var num in l1)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();
        // Deleting
        Console.WriteLine("Deleting:");
        l1.Remove(45); // Remove element 45
        foreach (var num in l1)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();
    }
}