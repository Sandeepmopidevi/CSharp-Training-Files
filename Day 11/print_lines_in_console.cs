using System;
using System.IO;

class s11 {
    static void Main(string[] args) {
        FileStream f = new FileStream(@"S:\Csharp\Day 11\nline.txt", FileMode.OpenOrCreate);
        StreamReader s1 = new StreamReader(f);
        string line = s1.ReadLine();
        Console.WriteLine(line);
        s1.Close();
        f.Close();
    }
}
