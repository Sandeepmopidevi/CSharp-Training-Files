using System;

class Task5
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        int product = 1;
        int reverseNumber = 0;

        int temp = number;
        while (temp != 0)
        {
            int digit = temp % 10;
            sum += digit;
            product *= digit;
            reverseNumber = reverseNumber * 10 + digit;
            temp /= 10;
        }

        Console.WriteLine("Sum of the given number is: " + sum);
        Console.WriteLine("Product of the given number is: " + product);

        if (sum == product)
        {
            Console.WriteLine("It is a spy number");
            Console.WriteLine("Given number in reverse order: " + reverseNumber);
        }
        else
        {
            Console.WriteLine("It is not a spy number");
        }
    }
}