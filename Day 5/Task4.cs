using System;

class Task4
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

        Console.Write("Target sum: ");
        int target = int.Parse(Console.ReadLine());

        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                    break;
                }
            }

        }

        Console.WriteLine("Indices of the two numbers: {0}, {1}", result[0], result[1]);
    }
}
