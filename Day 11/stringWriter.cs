using System;
using System.IO;
class C1{
    static void Main(string[] args){
        string s1="Hello Students welcome to Sandeep World\n"+
        "Hello Learners welcome to Sandeep World";
        using(StringWriter s2=new StringWriter()){
            s2.WriteLine(s1);
            Console.WriteLine(s2.ToString());
        }
    }
}