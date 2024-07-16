using System;
class Test34{
    int ssc;
    int inter;
    int btech;
    int mtech;
    public Test34(int ssc){
        this.ssc = ssc;
    }
    public Test34(int ssc,int inter){
        this.ssc = ssc;
        this.inter = inter;
    }
    public Test34(int ssc,int inter,int btech){
        this.ssc = ssc;
        this.inter = inter;
        this.btech = btech;
    }
    public Test34(int ssc,int inter,int btech,int mtech){
        this.ssc = ssc;
        this.inter = inter;
        this.btech = btech;
        this.mtech = mtech;
    }
    void Display(){
        Console.WriteLine(ssc);
        Console.WriteLine(ssc+"  "+inter);
        Console.WriteLine(ssc+"  "+inter+" "+btech);
        Console.WriteLine(ssc+"  "+inter+" "+btech+" "+mtech);
    }
    static void Main(string[] args){
        Test34 t1 = new Test34(100);
        Test34 t2 = new Test34(100,98);
        Test34 t3 = new Test34(100,98,94);
        Test34 t4 = new Test34(100,98,94,90);
        t4.Display();
    }
}