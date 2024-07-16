using System;
using System.IO;

class s11 {
    static void Main(string[] args) {
        FileStream f = new FileStream(@"S:\Csharp\Day 11\nline.txt", FileMode.Create);
        StreamWriter s1 = new StreamWriter(f);
        s1.WriteLine("Hello");
        s1.WriteLine("Hello Good morning");
        s1.Close();
        f.Close();
    }
}
