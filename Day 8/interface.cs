using System;
interface I1{
    void show();
}

class Test : I1{
    public void show(){
        Console.WriteLine("hi");
    }
    public static void Main(string[] args)
    {
        Test t1 = new Test();
        t1.show();
    }
}