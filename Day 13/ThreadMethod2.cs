using System;
using System.Threading;

class Animal
{
	public void Dog()
	{
		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine("Dog is running");
			Thread.Sleep(2000);
		}
	}

	public void Cat()
	{
		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine("Cat is running");
			Thread.Sleep(1000);
		}
	}
    public void Pig()
	{
		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine("pig is running");
			Thread.Sleep(3000);
		}
	}

	public static void Main()
	{
		Animal obj = new Animal();
		Thread t1 = new Thread(new ThreadStart(obj.Dog));
		Thread t2 = new Thread(new ThreadStart(obj.Cat));
        Thread t3=new Thread(new ThreadStart(obj.Pig));
		t1.Start();
		t2.Start();
        t2.Join(3000);
        Thread.Sleep(3000);
        t2.Abort();
        t3.Start();
	}
}