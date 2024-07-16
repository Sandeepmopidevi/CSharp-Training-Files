using System;
class Test9{
    int a;
    static int b;
    static Test9(){
        b=89;
    }
    public Test9(){
        a=78;
    }
    void display(){
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
    public static void Main(string[] args){
        Test9 t1 = new Test9();
        t1.display();
    }
}