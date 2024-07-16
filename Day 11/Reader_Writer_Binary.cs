using System;
using System.IO;
namespace Binary{
    class C1{
        static void Main(string[] args){
            WriteBinaryFile();
            ReadBinaryFile();
            Console.ReadKey();
        }
        static void WriteBinaryFile(){
            using(BinaryWriter writer = new BinaryWriter(File.Open(@"S:\Csharp\Day 11\test2.dat",FileMode.Create))){
                writer.Write(234);
                writer.Write("hi hellllo");
            }
    
        }
        static void ReadBinaryFile(){
            using(BinaryReader reader = new BinaryReader(File.Open(@"S:\Csharp\Day 11\test2.dat",FileMode.Open))){
                Console.WriteLine(reader.ReadInt32());
                Console.WriteLine(reader.ReadString());
            }
        }
    }
}