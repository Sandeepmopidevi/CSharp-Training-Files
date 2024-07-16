using System;
interface I
{
    void show();
}
class C1 : I
{
    public void show()
    {
        Console.WriteLine("Hello show from C1");
    }
}
interface I2 : I
{
    void show1();
}
class C2 : I
{
    public void show()
    {
        Console.WriteLine("Hello show from C2");
    }
    public void show2()
    {
        Console.WriteLine("Hello show2 from C2");
    }
}
class C : I2,C1,C2
{
    C1 c1 = new C1();
    C2 c2 = new C2();
    public void show()
    {
        c1.show(); 
    }
    public void show1()
    {
        Console.WriteLine("Hello show1 from I2");
    }
    public void show2()
    {
        c2.show2(); 
    }
}
class Test
{
    static void Main(string[] args)
    {
        C c = new C();
        c.show();
        c.show1(); 
        c.show2();
    }
}