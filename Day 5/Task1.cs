using System;
class Task1{
    static void Main(string[] args){
        Console.WriteLine("Enter the array elements separated by space:");
        string[] input = Console.ReadLine().Split(' ');
        int[] nums = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            nums[i] = int.Parse(input[i]);
        }
        int n= nums.Length+1;
        int sum = (n * (n + 1)) / 2;
        int ArrSum=0;
        foreach (int num in nums){
            ArrSum+=num;
        }
		int missingnumber=sum-ArrSum;
		Console.WriteLine("The Missing Number is:"+missingnumber);
    }
}