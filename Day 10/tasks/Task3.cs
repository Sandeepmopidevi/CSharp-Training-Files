using System;

class BulkStockException : Exception
{
    public BulkStockException(string productName) 
        : base("Error: The "+productName+" cannot be ordered in quantities of more than 10 units.")
    {
    }
}

class ShoppingCart
{
    public void AddToCart(string productName, int quantity)
    {
        if (quantity > 10)
        {
            throw new BulkStockException(productName);
        }
        else
        {
            Console.WriteLine(quantity+" units of "+productName+" added to the cart.");
        }
    }
}
class Task3
{
    static void Main(string[] args)
    {
        string productName = args[0];
        int quantity = int.Parse(args[1]);
        ShoppingCart cart = new ShoppingCart();
        try
        {
            cart.AddToCart(productName, quantity);
        }
        catch (BulkStockException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}