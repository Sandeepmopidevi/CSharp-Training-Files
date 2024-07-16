using System;
class MethOver{
    static void Show(int a,int b){
        Console.WriteLine("a: "+a+" b: "+b);
    }
    static void Show(int x,int y, int z){
        Console.WriteLine("x: "+x+" y: "+y+" z: "+z);
    }
    static void Main(string[] args){
        Show(10,20);
        Show(30,40,50);
    }
}