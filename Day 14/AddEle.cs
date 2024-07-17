using System;
using System.Collections.Generic;

class AddEle
{
	static void Main(string[] args)
	{
		List<int> numbers = new List<int>(){12,23,45,67,89};
		numbers.Insert(2, 11);
        numbers.Add(69);
        for (int i=0;i<numbers.Count;i++){
		Console.WriteLine(numbers[i]);
        }
	}
}