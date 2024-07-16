using System;
class Task2{
	static void Main(string[] args){
		Console.WriteLine("Enter a Value:");
		int n= Convert.ToInt32(Console.ReadLine());
		int flag=1;
		while(flag<n){
			flag*=2;
			if (flag==n){
				Console.WriteLine("True");
			}
		}
		if (flag!=n){
		Console.WriteLine("False");
	}
	}
}