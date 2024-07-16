using System;
class C1{
    public static void Main(String[] args) {
        try{
            int a=20;
            Console.WriteLine("Enter a Number");
            int b=Convert.ToInt32(Console.ReadLine());
            int c=show(a,b);
            Console.WriteLine(c);
        }catch(ArithmeticException e){
            Console.WriteLine(e.Message);
        }catch(FormatException){
            Console.WriteLine("Enter Correct Exception");
        }
        catch(Exception){
            Console.WriteLine("Enter Valid one");
        }
        }
    public static int show(int a,int b){
        if(b==0){
            throw new ArithmeticException("Zero Division Exception Raised");
        }
        return a/b;
    }
}