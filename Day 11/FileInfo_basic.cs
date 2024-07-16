using System;
using System.IO;

class C!{
    static void Main(string[] args){
        try{
            string s1 = @"S:\Csharp\Day 11\Sandeep.docx";
            FileInfo f1 = new FileInfo(s1);
            f1.Create();
            Console.WriteLine("File created successfully");
        }
        catch(IOException e){
            Console.WriteLine(e.Message);
        }
    }
}