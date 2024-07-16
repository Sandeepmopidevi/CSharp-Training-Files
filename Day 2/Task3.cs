using System;
namespace App{
class BOOK1{
	public void DisplayDetails(int bookid,string title,string author,double price,int copiesAveilable){
		Console.WriteLine("Book Id is:"+bookid);
		Console.WriteLine("Book Title is:"+title);
		Console.WriteLine("Book Author is:"+author);
		Console.WriteLine("Book price is:"+price);
		Console.WriteLine("Copies Aveilable:"+copiesAveilable);
}
	public void CalculatetotalValue(double price,int copiesAveilable){
		double value=price*copiesAveilable;
		Console.WriteLine("Total value of books:"+value);
}
}
class BOOK{
public static void Main(string[] args){
	BOOK1 b1=new BOOK1();
	b1.DisplayDetails(12,"abc","pra",20.22,3);
	b1.CalculatetotalValue(20.22,3);
}
}
}