using System;
namespace Sample{
    public class Test1{
        public static void Add(){
            Console.WriteLine("Hello!");
        }
    }
}
namespace Sample2{
    public class Test2{
        static void sub(){
            Console.WriteLine("hahaha");
        }
        static void Main(string[] args){
            Sample.Test1.Add();
            Test2.sub();
        }
}

}