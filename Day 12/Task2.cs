using System;
using System.IO;
class Task2{
    static void Main()
    {
        string[] filenames = { "S:/Csharp/Day 12/Sample1.txt", "S:/Csharp/Day 12/Sample2.txt", "S:/Csharp/Day 12/Sample3.txt" };
        Console.WriteLine("Enter file number to open (1, 2, 3):");
        int flnum = int.Parse(Console.ReadLine());
        string selflnm = filenames[flnum - 1];
        try
        {
            using (StreamReader sr = new StreamReader(selflnm))
            {
                Console.WriteLine("Content of "+selflnm);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File "+selflnm+" not found.");
        }
        catch (IOException)
        {
            Console.WriteLine("Error: Unable to read file "+selflnm);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: "+ex.Message);
        }
    }
}
/*
S:\Csharp\Day 12>Task2
Enter file number to open (1, 2, 3):
1
Content of Sample1.txt:
You Opened Sample1 File Successfully

S:\Csharp\Day 12>Task2
Enter file number to open (1, 2, 3):
2
Content of Sample2.txt:
You Opened Sample2 File Successfully
*/