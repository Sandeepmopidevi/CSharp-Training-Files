using System;
using System.IO;
class C1{
    static void Main(string[] args){
        FileStream f= new FileStream(@"S:\Csharp\Day 11\text.txt",FileMode.OpenOrCreate);
        for (int i=97;i<123;i++){
            f.WriteByte((byte)i);
        }
        f.Close();
    }
}