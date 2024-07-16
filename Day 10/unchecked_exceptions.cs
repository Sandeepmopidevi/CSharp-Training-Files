using System;
class C1{
    static void Main(string[] args){
        unchecked //checked
        {
            int x=int.MaxValue;
            Console.WriteLine(x);
        }
    }
}