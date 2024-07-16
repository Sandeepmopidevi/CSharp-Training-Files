using System;
class C1
{
static void Main()
{
int a = 20;
Console.WriteLine("Value of a: " + a);
int b = Convert.ToInt32(Console.ReadLine());
try
{
int c = show(a, b);
Console.WriteLine("Result of division: " + c);
}
catch (Exception ex)
{
Console.WriteLine("Exception caught: " + ex.Message);
}
}

public static int show(int a, int b)
{
if (b == 0)
{
throw new ArithmeticException("Division by zero is not allowed.");
}
return a / b;
}
}