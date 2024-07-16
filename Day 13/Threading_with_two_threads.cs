using System;
using System.Threading;
class Threading{
    public static void player1(){
        for (int i=0;i<5;i++){
            Console.WriteLine("Player 1 is playing");
        }  
    }
     public static void player2(){
        for (int i=0;i<5;i++){
            Console.WriteLine("Player 2 is playing");
        }  
    }
    static void Main(){
        Console.WriteLine("Main Thread");
        Thread t1 = new Thread(player1);
         Thread t2 = new Thread(player2);
        t1.Start();
        t2.Start();
        for (int i=0;i<5;i++){
            Console.WriteLine("Main player is Playing");
        }
    }
}