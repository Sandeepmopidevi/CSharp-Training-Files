using System;
using System.Reflection;
public class R2{
    public void M1(string a){
        Console.WriteLine(a);
    }
}
class R1{
    static void Main(string[] args){
        Type type =typeof(R2);
        MethodInfo[] methods = type.GetMethods();
        object ob = Activator.CreateInstance(type);
        methods[0].Invoke(ob,new object[] {"Hi Hello"});
    }
}