using System;
namespace Task1{
	class First{
		 public void Main(){
			Console.WriteLine("hi from class 1");
		}
	}
	class Second{
		public void Main(){
			Console.WriteLine("hello from class 2");
		}
	}
	class Program{
		public static void Main(string[] args){
			Second p1=new Second();
			p1.Main();
			First p2=new First();
			p2.Main();
			Console.WriteLine("hello world");
		}
	}
}
