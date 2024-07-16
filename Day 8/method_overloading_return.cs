using System;
class MethOver{
    static int Show(int a,int b){
        return a+b;
    }
    static int Show(int x,int y, int z){
        return x+y+z;
    }
    static void Main(string[] args){
       Console.WriteLine(Show(30,20));
       Console.WriteLine(Show(30,30,60));
    }
}