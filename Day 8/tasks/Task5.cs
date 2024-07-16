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

class C2 : C1, I2
{
    public void show1()
    {
        Console.WriteLine("Hello show1 from I2");
    }

    public void show()
    {
        base.show();
        Console.WriteLine("Hello show overridden in C2");
    }
}

class Test
{
    static void Main(string[] args)
    {
        C2 c2 = new C2();
        c2.show(); 
        c2.show1();
    }
}
