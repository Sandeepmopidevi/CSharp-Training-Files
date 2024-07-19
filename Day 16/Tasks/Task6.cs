using System;
class Task6
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter the elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        Console.Write("Sorted Array: [");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i]);
            if (i < n - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}