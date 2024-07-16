using System;
class Encap{
    private string name;
    public string Name{
        get{return name;}
        set{name=value;}
    }
}
class Test{
    public static void Main(string[] args){
        Encap obj=new Encap();
        obj.Name="Sandeep";
        Console.WriteLine("Name: "+obj.Name);
    }
}