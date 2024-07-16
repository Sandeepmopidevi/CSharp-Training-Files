using System;
using System.IO;

class Task3
{
    static void Main()
    {
        Console.WriteLine("Enter the text to write into the file: ");
        string input = Console.ReadLine();
        string filePath = "S:/Csharp/Day 12/Simple.txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.Write(input);
        }

        Console.WriteLine("Data written to file successfully.");
    }
}
/*
[02:29 pm] Nikhitha (Unverified)
using System;

using System.IO;
 
namespace WriteToFile

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter the text to write into the file:");
 
            string data = Console.ReadLine();
 
            try

            {

                string filePath = "Simple.txt";

                File.WriteAllText(filePath, data);
 
                Console.WriteLine("Data has been written to the file.");

            }

            catch (Exception e)

            {

                Console.WriteLine("An error occurred: " + e.Message);

            }

        }

    }

}
 */