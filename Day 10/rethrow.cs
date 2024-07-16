using System;
class C1{
    static void Main(string[] args){
        try{
            int a=20;
            Console.WriteLine("Enter a Number");
            int b=Convert.ToInt32(Console.ReadLine());
            Add(a,b);
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
        }
        public static void Add(int a,int b){
            try{
                int c=a/b;
                Console.WriteLine(c);
            }
            catch(ArithmeticException e){
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
