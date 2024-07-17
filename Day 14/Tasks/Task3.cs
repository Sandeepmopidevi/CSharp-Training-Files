using System;
using System.Collections.Generic;
class Task3
{
    static void Main()
    {
        List<string> plist = new List<string>
        {
            "Song1","Song2","Song3","Song4","Song5"
        };
        plist.Insert(2, "Happy");

        List<string> otherList = new List<string>
        {
            "Song6","Song7","Song8"
        };
        plist.InsertRange(3, otherList);
        foreach (string song in plist)
        {
            Console.WriteLine(song);
        }
    }
}