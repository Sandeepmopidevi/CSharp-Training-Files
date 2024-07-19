using System;

class Task2
{
    static void Main()
    {
        Console.WriteLine("Enter the number of people:");
        int numberOfPeople = int.Parse(Console.ReadLine());

        string[] names = new string[numberOfPeople];
        int[] ages = new int[numberOfPeople];

        for (int i = 0; i < numberOfPeople; i++)
        {
            Console.WriteLine("Enter name for person "+i + 1);
            names[i] = Console.ReadLine();

            Console.WriteLine("Enter age for person "+i + 1);
            ages[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Celebrating Birthdays:");

        for (int i = 0; i < numberOfPeople; i++)
        {
            ages[i]++;
            Console.WriteLine(names[i]+" is celebrating their birthday! They are now "+ages[i]+" years old.");
        }
    }
}