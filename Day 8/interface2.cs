using System;
interface I1
{
    void show();
}
class c1:I1
{
    public void show()
    {
        Console.WriteLine("hello frnds");
    }
    
}
class c2:I1
{
    public void show()
    {
        Console.WriteLine("hii frnds");
    }
    }
    public class Test{
        static void Main(string[] args)
    {
        c2 d1 = new c2();
        c1 d2 = new c1();
        d1.show();
        d2.show();
    }
} 