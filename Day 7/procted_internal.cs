using System;
namespace ProInt{
    class Test3{
        protected internal void show(){
            Console.WriteLine("Hello World");
        }
    }
}
namespace ProInt1{
    class Test4{
        void display(){
            Console.WriteLine("Good Morning");
        }
        static void Main(string[] args){
            ProInt.Test3 t1=new ProInt.Test3();
            t1.show();
            Test4 t2=new Test4();
            t2.display();
        }
    }
}