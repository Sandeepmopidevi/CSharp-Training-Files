using System;
class Task7
{
    static void Main(string[] args)
    {
        string animalName = args[0].ToLower();
        switch (animalName)
        {
            case "dog":
                Console.WriteLine("The dog barks.");
                break;
            case "cat":
                Console.WriteLine("The cat meows.");
                break;
            case "cow":
                Console.WriteLine("The cow moos.");
                break;
            default:
                Console.WriteLine("Unknown animal.");
                break;
            
        }
    }
}