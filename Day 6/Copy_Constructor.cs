using System;
class Test41{
    string s1;
    int age;
    public Test41(string s1,int age){
        this.s1=s1;
        this.age=age;
    }
    public Test41(Test41 t1){
        this.s1=t1.s1;
        this.age=t1.age;
    }
    void Display(){
        Console.WriteLine(s1+" "+age);
    }
    static void Main(string[] args){
        Test41 t2=new Test41("sandeep",18);
        Test41 t3=new Test41("sandeep",21);
        t2.Display();
        t3.Display();
    }
}
    