using System;
class Task1{
    public static void Main(string[] args){
    int a = 92;
    long b = a;
    long f=34;
    float g=f;
    float c = 89.23F;
    double d = c;
    Console.WriteLine(b);
    Console.WriteLine(b.GetType());
    Console.WriteLine(g);
    Console.WriteLine(g.GetType());
    Console.WriteLine(d);
    Console.WriteLine(d.GetType());
    }
}