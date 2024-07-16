using System;
class OverLoad{
    public virtual void Taste(){
        Console.WriteLine("Dairy Milk");
    }
}
class OverLoad2:OverLoad{
    public override void Taste(){    //virtual✔   // without virtual or override✔
        Console.WriteLine("5 Star");
    }
    public static void Main(string[] args){
        OverLoad2 obj=new OverLoad2();
        obj.Taste();
    }
}