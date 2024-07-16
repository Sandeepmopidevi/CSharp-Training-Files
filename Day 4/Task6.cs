using System;

class Task6
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            char alphabet = 'A';
            for (int k = 1; k <= i; k++)
            {
                Console.Write(alphabet + " ");
                alphabet++;
            }
            Console.WriteLine();
        }
    }
}