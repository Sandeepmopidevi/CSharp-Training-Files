using System;
using System.IO;
using System.Text;
class C1{
    static void Main(string[] args){
        string txt="Hello Students welcome to Sandeep World\n"+
        "Hello Learners welcome to Sandeep World";
        StringBuilder sb=new StringBuilder();
        StringWriter w=new StringWriter(sb);
        w.WriteLine(txt);
        w.Flush();
        w.Close();
        StringReader r=new StringReader(txt.ToString());
        while (r.Peek()>-1){
            Console.WriteLine(r.ReadLine());
        }
        
        }
}