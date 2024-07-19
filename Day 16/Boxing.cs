using System;

//Boxing is a process of converting a value type to object type
class Box
{
    public static void Main(string[] args)
    {
        //implicit unboxing is not working
        object j = 89;
        int y = (int)j;
        Console.WriteLine(y.GetType());//Explicit (UnBoxing)
    }
}