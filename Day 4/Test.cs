using System;
class Test29{
public void Show(int a){
a+=5;
Console.WriteLine(a);
}
static void Main(string[] args){
	int a=5;
Test29 tl=new Test29();
tl.Show(a);
Console.WriteLine(a);
}
}
/*
using System;
class Test29{
public void Show(int a){
a+=5;
Console.WriteLine(a);
}
static void Main(string[] args){
	int a=5;
Test29 tl=new Test29();
tl.Show(ref a);
Console.WriteLine(a);
}
}
*/