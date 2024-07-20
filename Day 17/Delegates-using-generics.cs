using System;
using System.Collections.Generic;
delegate T M1<T>(T a, T b);
class D2{
    public static double area(double height,double width){
        return height*width;
    }
    public static double perimeter(double height,double width){
        return 2*(height+width);
    }
    static void Main(string[] args){
        M1<double> d1 = new M1<double>(area);
        M1<double> d2=new M1<double>(area);
        Console.WriteLine(d1(4,5.4));
        Console.WriteLine(d2(6,7.8));
    }
}