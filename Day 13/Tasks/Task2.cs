using System;
using System.Threading;

class Task2
{
    static void Run(object runnerName)
    {
        string name = (string)runnerName;
        Console.WriteLine(name+" started running.");

        for (int lap = 1; lap <= 5; lap++)
        {
            Console.WriteLine(name+" completed lap"+ lap);
            Thread.Sleep(1000);
            if (lap < 5)
            {
                Console.WriteLine(name+" taking a short break.");
                Thread.Sleep(500);
            }
        }

        Console.WriteLine(name+" finished running.");
    }
    static void Main()
    {
        Thread runner1 = new Thread(Run);
        Thread runner2 = new Thread(Run);
        Thread runner3 = new Thread(Run);
        runner1.Start("Runner 1");
        runner2.Start("Runner 2");
        runner3.Start("Runner 3");
        runner1.Join();
        runner2.Join();
        runner3.Join();
        Console.WriteLine("Race finished!");
    }
}