using System;
public delegate string MyDel(string str);
class C1{
    public static string addHello(string str){
        return "Hello "+str;
    }
    public static string addWelcome(string str){
        return "Welcome "+str;
    }
    static void Main(string[] args){
        MyDel del1 = new MyDel(addHello);
        MyDel del2 = new MyDel(addWelcome);
        MyDel del3 = del1+del2;
        string result = del3("User");
        Console.WriteLine(result);
    }
}