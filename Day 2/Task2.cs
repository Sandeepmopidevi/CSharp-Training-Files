using System;
namespace Task2{
    class arithmeticOperations{
        public static void add(int a, int b){
            Console.WriteLine("Sum of "+a+" and "+b+" is "+(a+b));
        }
        public static void subtract(int a, int b){
            Console.WriteLine("Difference of "+a+" and "+b+" is "+(a-b));
        }
        public static void multiply(int a, int b){
            Console.WriteLine("Product of "+a+" and "+b+" is "+(a*b));
        }
        public static void divide(int a, int b){
            Console.WriteLine("Quotient of "+a+" and "+b+" is "+(a/b));
        }
    }
    public class Task2{
        public static void Main(string[] args){
            int a=20;
            int _b=30;
            int @c=50;
        arithmeticOperations.add(a,_b);
        arithmeticOperations.subtract(a,@c);
        arithmeticOperations.multiply(a,_b);
    }
}
}
