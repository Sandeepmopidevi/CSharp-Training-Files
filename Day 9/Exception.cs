using System;
class S10{
    public void show(){
        int a = 10;
        int t = 0;
        int c = a/t;
    }
    static void Main(string[] args){
        S10 s = new S10();       //syntax error
        s.show();
    }
}