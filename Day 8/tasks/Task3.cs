using System;

interface I1
{
    void show();
}

interface I2 : I1
{
    void show1();
}

interface I3 : I1
{
    void show2();
}

interface I4 : I1
{
    void show3();
}

class C : I2, I3, I4
{
    public void show()
    {
        Console.WriteLine("Hello show from I1");
    }

    public void show1()
    {
        Console.WriteLine("Hello show1 from I2");
    }

    public void show2()
    {
        Console.WriteLine("Hello show2 from I3");
    }

    public void show3()
    {
        Console.WriteLine("Hello show3 from I4");
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
        c.show3(); 
    }
}
