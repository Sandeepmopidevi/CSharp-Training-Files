using System;
delegate void change(int n);
class C4{
    static int num=12;
    public static void add(int p){
        num+=p;
        Console.WriteLine("Value of num: "+num);
    }
    public static void sub(int x){
        num-=x;
        Console.WriteLine("Value of num: "+num);
    }
    public static int getNum(){
        return num;
    }
    static void Main(string[] args){
        change n = delegate(int a)
        {
            Console.WriteLine("Anonymous method: "+a);
        };
        n=new change(add);
        n(5);
        n=new change(sub);
        n(3);
        Console.WriteLine("Value of num: "+getNum());
    }
}