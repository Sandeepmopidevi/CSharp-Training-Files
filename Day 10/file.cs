using System;
using System.IO;
class C1{
    static void Main(string[] args){
        string file=@"S:\Csharp\Day 10\haha.txt";
        Console.WriteLine("Read a file");
        if (File.Exists(file)){
            string str=File.ReadAllText(file);
            Console.WriteLine(str);
        }
    }
}