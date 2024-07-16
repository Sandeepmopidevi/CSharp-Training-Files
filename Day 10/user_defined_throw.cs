using System;
class C1{
    static void Main(string[] args){
        int a=20;
        Console.WriteLine("Enter a Number");
        int b=Convert.ToInt32(Console.ReadLine());
        try{
            int c=show(a,b);
            Console.WriteLine(c);
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
    }

    public static int show(int a,int b){
        if(b==0){
            throw new ArithmeticException("Zero Division Exception Raised");
        }
        return a/b;
    }
}
