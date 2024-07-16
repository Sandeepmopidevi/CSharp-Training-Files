using System;
using System.IO;

class C1 {
    static void Main(string[] args) {
        string f1 = @"S:\Csharp\Day 11\text2.dat" ;
        using(BinaryWriter w = new BinaryWriter(File.Open(f1, FileMode.Create))){
            w.Write(234);
            w.Write("hi hellllo");
        }
    }
}