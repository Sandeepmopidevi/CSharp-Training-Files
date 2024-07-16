using System;
public class Calculator
{
    private int additionVariable1;
    private int additionVariable2;
    private static int subtractionVariable;
    private int multiplicationVariable;

    public Calculator(int additionVariable1, int additionVariable2, int multiplicationVariable)
    {
        this.additionVariable1 = additionVariable1;
        this.additionVariable2 = additionVariable2;
        this.multiplicationVariable = multiplicationVariable;
    }

    public int Addition()
    {
        return additionVariable1 + additionVariable2;
    }

    public static int Subtraction(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiplication()
    {
        return additionVariable1 * multiplicationVariable;
    }

    public void UpdateMultiplicationVariable(int newMultiplicationVariable)
    {
        multiplicationVariable = newMultiplicationVariable;
    }

    public int Division(int divisor)
    {
        return multiplicationVariable / divisor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator(5, 3, 10);

        int additionResult = calculator.Addition();
        Console.WriteLine("Addition Result: " + additionResult);

        int subtractionResult = Calculator.Subtraction(10, 5);
        Console.WriteLine("Subtraction Result: " + subtractionResult);

        int multiplicationResult = calculator.Multiplication();
        Console.WriteLine("Multiplication Result: " + multiplicationResult);

        calculator.UpdateMultiplicationVariable(5);
        int divisionResult = calculator.Division(2);
        Console.WriteLine("Division Result: " + divisionResult);
    }
}