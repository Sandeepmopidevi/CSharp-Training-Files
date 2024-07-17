using System;
using System.Collections.Generic;

class T1{
    static void Main(string[] args)
    {
        string[] s1 = {"gec","cse","hello"};
        List<string> l1=new List<string>();
        l1.InsertRange(0, s1);
        l1.Add("World");
        foreach(string x in l1){
            Console.WriteLine(x);
        }
}}