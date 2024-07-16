using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the array elements separated by space:");
        string[] input = Console.ReadLine().Split(' ');

        int[] nums = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            nums[i] = int.Parse(input[i]);
        }

        Console.WriteLine("Duplicate values in the array:");

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)  
            {
                if (nums[i] == nums[j])
                {
                    Console.WriteLine(nums[i]);
                }
            }
        }
    }
}