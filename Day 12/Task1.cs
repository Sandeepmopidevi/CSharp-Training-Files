using System;
using System.IO;
class C1
{
    static void Main()
    {
        string filePath = "S:/Csharp/Day 12/q1574/sample.txt";
        using (StreamReader sr = new StreamReader(filePath))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}