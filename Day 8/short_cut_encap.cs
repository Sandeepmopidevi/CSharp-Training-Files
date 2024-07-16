using System;
class Encap{
    public string Name{get; set;}
}
class Test{
    public static void Main(string[] args){
        Encap obj=new Encap();
        obj.Name="Sandeep";
        Console.WriteLine("Name: "+obj.Name);
    }
}