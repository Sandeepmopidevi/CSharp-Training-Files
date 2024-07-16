using System;
class Task2
{
    static void Main()
    {
        Console.WriteLine("Did you clear the written test? (yes/no):");
        string testres = Console.ReadLine();
        if (testres=="yes")
        {
            Console.WriteLine("You are eligible for the group discussion round");
            Console.WriteLine("Did you pass the group discussion round? (yes/no):");
            string gdres = Console.ReadLine();
            if (gdres=="yes")
            {
                Console.WriteLine("You are eligible for the technical round");
                Console.WriteLine("Did you pass the technical round? (yes/no):");
                string techres=Console.ReadLine();
                if (techres=="yes")
                {
                    Console.WriteLine("Congrats! You are eligible for the HR round");
                }
                else
                {
                    Console.WriteLine("Sorry, You can go home");
                }
            }
            else
            {
                Console.WriteLine("Sorry, You can go home");
            }
        }
        else
        {
            Console.WriteLine("Sorry, You can go home");
        }
    }
}