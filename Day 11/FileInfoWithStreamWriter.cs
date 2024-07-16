using System;
using System.IO;

class F19{
    static void Main(string[] args){
        try{
            string s1 = @"S:\Csharp\Day 11\Sandeep.docx";
            FileInfo f1 = new FileInfo(s1);
            StreamWriter s2 = f1.CreateText();
            s2.WriteLine("Good morinng"); 
            s2.Close(); 
            Console.WriteLine("File created successfully");
        }
        catch(IOException e){
            Console.WriteLine(e.Message);
        }
    }
}
