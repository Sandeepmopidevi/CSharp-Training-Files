using System;
class C1{
    public C1(){
        Console.WriteLine("Constructor without parameter");
    }
}
    class C2:C1{
        public C2():base(){
            Console.WriteLine("Constructor without parameter");
        }
        static void Main(string[] args){
            C2 obj = new C2();
            }
        }
    

