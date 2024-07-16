using System;

interface I1
{
    void show();
}

class CA
{
    public void cM()
    {
        Console.WriteLine("Hello Class Method");
    }
}

class c1 : CA, I1
{
    public void show()
    {
        Console.WriteLine("Hello Frnds");
    }
}

class Test
{
    static void Main(string[] args)
    {
        c1 t1 = new c1();
        t1.show();
        t1.cM();
    }
}
