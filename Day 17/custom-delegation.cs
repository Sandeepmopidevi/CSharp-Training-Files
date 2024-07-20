using System;

class C3
{
    public delegate int Show(int a, int b, int c);

    public static int Display(int a, int b, int c)
    {
        return a + b * c;
    }

    static void Main(string[] args)
    {
        Show s = Display;
        //s(10,20,30)
        Console.WriteLine(s.Invoke(10, 20, 30));
    }
}