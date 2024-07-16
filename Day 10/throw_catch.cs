using System;
class C1{
    static void Main(string[] args){
        int a=20;
        Console.WriteLine("Enter a Number");
        int b=Convert.ToInt32(Console.ReadLine());
        try{
            if(b==0){
                throw new ArithmeticException("Zero Division Exception Raised");
            
            }
            int c=a/b;
            Console.WriteLine(c);
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
    }
}