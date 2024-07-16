using System;
using System.IO;
class C1{
    static void Main(string[] args){
        StringWriter str=new StringWriter();
        str.WriteLine("Hello Students welcome to Sandeep World\n"+
        "Hello Learners welcome to Sandeep World");
        str.Close();
        StringReader r=new StringReader(str.ToString());
        while (r.Peek()>-1){
            Console.WriteLine(r.ReadLine());
        }
    }
}