using System;
class C1{
    public delegate void add(int a,int b);
    public delegate void sub(int a,int b);
    public void sum(int a,int b){
        Console.WriteLine(a+b);
    }
    public void minus(int a,int b){
        Console.WriteLine(a-b);
    }
    public static void Main(string[] args){
        C1 c = new C1();
        add a = new add(c.sum);
        sub s = new sub(c.minus);
        a(10,20);
        s(30,20);
        a(34,43);
    }
}