using System;
using System.Threading;
class Threading{
    public static void player1(){
        for (int i=0;i<5;i++){
            Console.WriteLine("Player 1 is playing");
        }  
    }
    static void Main(){
        Console.WriteLine("Main Thread");
        Thread t1 = new Thread(player1);
        t1.Start();
        for (int i=0;i<5;i++){
            Console.WriteLine("Main player is Playing");
        }
    }
}