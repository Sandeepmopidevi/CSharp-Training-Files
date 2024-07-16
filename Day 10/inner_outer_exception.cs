using System;
class C1{
    static void Main(string[] args){
        try{
            div();
        }
        catch(ApplicationException e){
            Console.WriteLine("Outer Exception: "+e.Message);
            if(e.InnerException!= null){
                Console.WriteLine("Inner Exception: "+e.InnerException.Message);
            }
        }
    }
    public static void div(){
        try{
            int a=20;
            Console.WriteLine("Enter a Number");
            int b=Convert.ToInt32(Console.ReadLine());
            int c =a/b; 
            Console.WriteLine("Result: "+c);
        }
        catch(Exception e) {
            Console.WriteLine("Exception: "+e.Message);
        }
    }    
}