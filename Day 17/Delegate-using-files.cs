using System;
using System.IO;

public delegate string MyDel(string str);
class C1
{
    public static string addWelcome(string str)
    {
        return "Welcome " + str;
    }
    static void Main(string[] args)
    {
        MyDel del1 = new MyDel(addWelcome);
        string result = del1("Sandeep");
        Console.WriteLine(result);
        File.WriteAllText(@"S:\CSharp\Day 17\result.txt", result);
    }
}