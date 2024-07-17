using System;
using System.Collections.Generic;

class Collections
{
	static void Main(string[] args)
	{
		List<int> list = new List<int>();
		list.Add(30);
		list.Add(89);
		list.Add(76);
		foreach (int x in list)
		{
			Console.WriteLine(x);
		}
	}
}