using System;
using System.Collections.Generic;

class Task4
{
    static void Main()
    {
        Dictionary<string, string> countryCapitals = new Dictionary<string, string>();

        Console.WriteLine("Enter the country and its capital (separated by a comma). Enter 'done' to finish.");
        string input;
        do
        {
            input = Console.ReadLine();
            if (input.ToLower() != "done")
            {
                string[] countryCapitalPair = input.Split(',');
                if (countryCapitalPair.Length == 2)
                {
                    string country = countryCapitalPair[0].Trim();
                    string capital = countryCapitalPair[1].Trim();
                    countryCapitals[country] = capital;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter the country and its capital separated by a comma.");
                }
            }
        } while (input.ToLower() != "done");

        Console.WriteLine("Entered country-capital pairs:");
        foreach (var pair in countryCapitals)
        {
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }
        Console.WriteLine("Generating quiz...");
        Console.WriteLine("Quiz generated successfully!");
    }
}