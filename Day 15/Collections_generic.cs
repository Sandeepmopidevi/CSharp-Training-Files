using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

class C1{
    public static void Main(string[] args){
        Collection<string> i1=new Collection<string>();
        i1.Add("A");
        i1.Add("B");
        i1.Add("C");
        Console.WriteLine("No of Elements"+i1.Count);
        var enumerator =i1.GetEnumerator();
        while(enumerator.MoveNext()){
            Console.WriteLine(enumerator.Current);
        }
       enumerator.Reset();
        Console.WriteLine("No of Elements"+i1.Count);
        while(enumerator.MoveNext()){
            Console.WriteLine(enumerator.Current);
        }
    }
}
