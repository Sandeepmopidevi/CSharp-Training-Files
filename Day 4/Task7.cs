using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the Sentence: ");
        string sentence = Console.ReadLine();
        Console.Write("Enter a word to find: ");
        string word = Console.ReadLine();
        int index = sentence.IndexOf(word);
        if (index != -1)
        {
            Console.WriteLine("The word "+word+" is found at index "+index+" in the sentence.");
        }
        else
        {
            Console.WriteLine("The word "+word+" is not found in the sentence.");
        }
    }
}