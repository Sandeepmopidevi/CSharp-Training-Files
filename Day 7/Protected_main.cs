using System;
using Sample;
namespace Test1{
    class Test1: Test{
        void display(){
            Console.WriteLine("Good Morning");
        }
        static void Main(string[] args){
            Test1 t2=new Test1();
            t2.display();
            t2.show();
        }
    }
}