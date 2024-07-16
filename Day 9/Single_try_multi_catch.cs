using System;

class S1 {
    static void Main(string[] args) {
        try {
            int a = 10;
            Console.WriteLine("Enter B Value");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a / b;
            Console.WriteLine(c);
        } catch (Exception e) {
            if (e is FormatException || e is DivideByZeroException) {
                Console.WriteLine(e.Message);
            } else {
                throw; 
            }
        }

        Console.WriteLine("Bye");
    }
}
