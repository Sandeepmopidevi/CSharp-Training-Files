using System;
class S1{
    public string Name{get; set;}
}
class S2:S1{
    public void Add(){
        Console.WriteLine(base.Name);
    }
    public static void Main(string[] args){
        S2 s =new S2();
        s.Name="Sandeep";
        s.Add();
    }
}
