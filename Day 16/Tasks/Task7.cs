using System;
class Task7
{
    static void Main()
    {
        Console.Write("Enter the number of elements for the first array: ");
        int n1 = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n1];
        Console.WriteLine("Enter the elements for the first array:");
        for (int i = 0; i < n1; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter the number of elements for the second array: ");
        int n2 = int.Parse(Console.ReadLine());

        int[] arr2 = new int[n2];
        Console.WriteLine("Enter the elements for the second array:");
        for (int i = 0; i < n2; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }

        bool areEqual = ArraysEqual(arr1, arr2);
        if (areEqual)
        {
            Console.WriteLine("Arrays are equal");
        }
        else
        {
            Console.WriteLine("Arrays are not equal");
        }
    }

    static bool ArraysEqual(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            return false;
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }

        return true;
    }
}