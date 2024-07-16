using System;
using System.Threading;
class Task1
{
   
    static void PerformAction(object characterName)
    {
        string name = (string)characterName;

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(name+" is performing action "+i);
            Thread.Sleep(500);
        }
    }
     static void Main()
    {
        Thread ch1Th = new Thread(PerformAction);
        Thread ch2Th = new Thread(PerformAction);
        Thread ch3Th = new Thread(PerformAction);
        ch1Th.Start("Character 1");
        ch2Th.Start("Character 2");
        ch3Th.Start("Character 3");
        ch1Th.Join();
        ch2Th.Join();
        ch3Th.Join();
        Console.WriteLine("All characters have finished their actions.");
    }
}