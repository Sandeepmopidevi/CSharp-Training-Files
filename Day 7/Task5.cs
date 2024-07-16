/*Consider a bank scenario where the user is having a fixed initial amount of 10000 which is defined in the class FixedAmount.
Create an abstract class named WithdrawalAmount with an abstract method withdraw which accepts an integer argument
Also in the main class Bank define the withdraw method which shows the available balance after withdrawal.
Sample Test Case:
Command line args 350
Maintain minimum balance10000
the available balance:9650*/
using System;
class Task5
{
    static void Main(string[] args)
    {
        string num = args[0];
        int amount = Int32.Parse(num);
        Console.WriteLine("Maintain minimum balance 10000");
        if (amount<10000){
        Console.WriteLine("The available balance: " + (10000 - amount));
    }else{
        Console.WriteLine("Can't Draw the Amount, Minimum Balance Exceeded");
    }
}
}
