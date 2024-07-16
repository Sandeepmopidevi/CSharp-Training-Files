using System;
using System.IO;

class F19{
    static void Main(string[] args){
        DirectoryInfo d1 = new DirectoryInfo(@"S:\Csharp\Day 11\Sandeep");
        try{
            if(d1.Exists){
                 Console.WriteLine("Directory already exists");
             }
             else{
                 d1.Create();
                 Console.WriteLine("Directory created successfully");
             }
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
    }
}