using System;

class Task3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of employees:");
        int numberOfEmployees = int.Parse(Console.ReadLine());
        double totalSalary = 0;
        for (int i = 1; i <= numberOfEmployees; i++)
        {
            Console.WriteLine("Enter name for employee " + i + ":");
            string name = Console.ReadLine();
            Console.WriteLine("Enter salary for employee " + i + ":");
            double salary = double.Parse(Console.ReadLine());

            totalSalary += salary;
        }
        Console.WriteLine("Total salary of all employees: " + totalSalary);
    }
}