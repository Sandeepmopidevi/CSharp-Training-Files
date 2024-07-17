using System;
using System.Collections.Generic;

class AddEle
{
	static void Main(string[] args)
	{
		List<int> numbers = new List<int>(){12,23,45,67,89};
		numbers.Remove(12);
        numbers.RemoveAt(2);
        for (int i=0;i<numbers.Count;i++){
		Console.WriteLine(numbers[i]);
        }
	}
}