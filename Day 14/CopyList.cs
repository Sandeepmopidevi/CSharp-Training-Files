using System;
using System.Collections.Generic;

class CopyList
{
	static void Main(string[] args)
	{
		List<string> list1 = new List<string>();
		list1.Add("Abc");
		list1.Add("apple");
		list1.Add("cat");

		List<string> list2 = new List<string>();
		list2.AddRange(list1);

		foreach (string x in list2)
		{
			Console.WriteLine(x);
		}
	}
}