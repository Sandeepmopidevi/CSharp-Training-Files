using System;
using System.Collections.Generic;

class ContainsList
{
	static void Main(string[] args)
	{
		List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

		Console.WriteLine(numbers.Contains(12));
		
		foreach (int x in numbers)
		{
			Console.WriteLine(x);
		}
	}
}