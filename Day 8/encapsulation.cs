using System;
class Encap{
    private string name;
    public string GetName(){
        return name;
    }
    public void SetName(string newName){
        name=newName;
    }
}
class Test{
    public static void Main(string[] args){
        Encap obj=new Encap();
        obj.SetName("Sandeep");
        Console.WriteLine("Name: "+obj.GetName());
    }
}