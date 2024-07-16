using System;
class S1{
    static void Main(string[] args){
        try{
            int a = 10;
            int t = 0;
            int c = a/t;
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
    }
}