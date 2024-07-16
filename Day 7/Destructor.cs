using System;
class Dest{
    public Dest(){
        Console.WriteLine("Constructor is called");
    }
    ~Dest(){
        Console.WriteLine("Destructor is called");
    }
    static void Main(string[] args){
        
        Dest d1=new Dest();
    }
}