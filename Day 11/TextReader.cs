using System;
using System.IO;

class C1 {
    static void Main(string[] args) {
        using (TextReader t = File.OpenText(@"S:\Csharp\Day 11\haha.txt")) {
            Console.WriteLine(t.ReadToEnd());
        }
        
    }
}
