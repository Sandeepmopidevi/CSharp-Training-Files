using System;
class S1{
    public string name {get; set;}
    public S1(string name){
        this.name = name;
        Console.WriteLine("Constructor with parameter");
    }
}
class S2:S1{
    public int id{get;set;}
    public S2(string name, int id):base(name){
        this.id = id;
        Console.WriteLine("Constructor with parameter");
    }
    static void Main(string[] args){
        S2 obj = new S2("Sandeep", 7);
        Console.WriteLine("Name: "+obj.name);
        Console.WriteLine("ID: "+obj.id);
    }
}