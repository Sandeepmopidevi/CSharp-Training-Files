using System;
using System.Collections.Generic;
class Task2
{
    static void Main()
    {
        List<string> BookTitles = new List<string>
        {
            "Book A","Book B","Book C","Book D","Book E"
        };
        string BTarget = "Book C";
        int index = BookTitles.IndexOf(BTarget);
        if (index != -1)
        {
            Console.WriteLine("The index of "+BTarget+" is "+index);
        }
        else
        {
            Console.WriteLine(BTarget+" was not found in the list.");
        }
    }
}