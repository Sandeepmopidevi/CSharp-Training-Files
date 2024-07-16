//base=Super in Java
using System;
class OverLoad{
    public virtual void Taste(){
        Console.WriteLine("Dairy Milk");
    }
}
class OverLoad2:OverLoad{
    public virtual void Taste(){
        Console.WriteLine("5 Star");
    }
}
    class Test:OverLoad2{
        public override void Taste(){
            base.Taste();
            Console.WriteLine("Munch");
            
        }
    public static void Main(string[] args){
        Test obj=new Test();
        obj.Taste();
        
    }
}