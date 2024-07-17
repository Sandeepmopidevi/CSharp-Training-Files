using System;
using System.Collections.Generic;

class C3
{
	static void Main(string[] args)
	{
		List<string> list = new List<string>();
		list.Add("abc");
		list.Add("abc");
		list.Add("abc");
        Console.WriteLine(list[0]);
        Console.WriteLine(list[1]);
        Console.WriteLine(list[2]);
		Console.WriteLine("First way:");
		foreach (string x in list)
		{
			Console.WriteLine(x);
		}

		Console.WriteLine("Second way:");
		for (int i = 0; i < list.Count; i++)
		{
			Console.WriteLine(list[i]);
		}
        Console.WriteLine("Third way:");
		list.ForEach(y => Console.WriteLine(y));
	}
}