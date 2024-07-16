using System;
interface I1{
    void show();
}
interface I2{
    void display();
}
class Test : I2,I1{
    public void show(){
        Console.WriteLine("hi");
    }
    public void display(){
        Console.WriteLine("hello");
    }
    public static void Main(string[] args)
    {
        Test t1 = new Test();
        t1.show();
        t1.display();
    }
}