using System;
struct Test{
    public void show(){
        Console.WriteLine("Hello World");
    }
    public static void Main(string[] args){
        Test t=new Test();
        t.show();
    }
}