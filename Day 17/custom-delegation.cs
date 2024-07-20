using System;
class C3{
    public delegate int show(int a,int b,int c);
    public static int display(int a,int b,int c){
        return a+b*c;
    }
    static void Main(string[] args){
        show s= display;
        Console.WriteLine(s(10,20,30));
    }
}