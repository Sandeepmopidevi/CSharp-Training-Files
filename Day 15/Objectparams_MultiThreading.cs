using System;
using System.Threading;
class Animal{
    static void Dog(object param){
        int n = (int)param;
        for (int i=0;i<n;i++){
            Console.WriteLine("Dog is running lap"+i);
            Console.WriteLine("Dog is Sleeping");
        }
        Console.WriteLine("Dog Finished Running");
    }
    static void Cat(object param){
        int n = (int)param;
        for (int i=0;i<n;i++){
            Console.WriteLine("Cat is running lap"+i);
            Console.WriteLine("Cat is Sleeping");
        }
        Console.WriteLine("Cat Finished Running");
    }
    static void Main(){
       int n=Convert.ToInt32(Console.ReadLine());
        Thread t1 = new Thread(new ParameterizedThreadStart(Dog));
        Thread t2 = new Thread(new ParameterizedThreadStart(Cat));
        t1.Start(n);
        t2.Start(n);
        t1.Join();
        t2.Join();
    }
}