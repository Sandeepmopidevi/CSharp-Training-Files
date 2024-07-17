using System;
using System.Collections.Generic;

class C1
{
	static void Main(string[] args)
	{
		List<string> list = new List<string>();
		list.Add("abc");
        list.Add("xyz");
		int inx2=list.IndexOf("xyz");
        if (inx2>0){
		Console.WriteLine("the value present:"+inx2);
        }
        else{
            Console.WriteLine("the value not present:");
        }
		foreach (string x in list)
		{
			Console.WriteLine(x);
		}
	}
}