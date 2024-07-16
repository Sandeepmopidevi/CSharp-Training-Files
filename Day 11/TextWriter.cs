using System;
using System.IO;

class C1 {
    static void Main(string[] args) {
        using (TextWriter t = File.CreateText(@"S:\Csharp\Day 11\haha.txt")) {
            t.WriteLine("Dinesh Heroooooine!");
            t.WriteLine("Shyam Herovine");
        }
    }
}
