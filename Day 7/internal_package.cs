using System;
namespace Internal{
    public class Test{
        internal void show(){
            Console.WriteLine("Hello World");
        }
    }
    class Test2{
        void display(){
            Console.WriteLine("Good Morning");
        }
        static void Main(string[] args){
        Test2 t1=new Test2();
        t1.display();
        Test t=new Test();
        t.show();
    }
}
}