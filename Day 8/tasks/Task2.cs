using System;

interface I1
{
    void show();
}

class ClassA : I1
{
    public void show()
    {
        Console.WriteLine("Hello Show Class A");
    }

    public void methodA()
    {
        Console.WriteLine("Hello From Class A");
    }
}

class ClassB : I1
{
    public void show()
    {
        Console.WriteLine("Hello Show Class B");
    }

    public void methodB()
    {
        Console.WriteLine("Hello from Class B");
    }
}

class ClassC : ClassA
{
    public void methodC()
    {
        Console.WriteLine("Hello From Class C");
    }
}

class Test
{
    static void Main(string[] args)
    {
        ClassA a = new ClassA();
        a.show();
        a.methodA();

        ClassB b = new ClassB();
        b.show();
        b.methodB();

        ClassC c = new ClassC();
        c.show();  
        c.methodA();
        c.methodC();
    }
}
