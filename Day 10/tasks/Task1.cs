using System;
public class  InvalidCouponCode:Exception
{
    public InvalidCouponCode(string message):base(message)
    {

    }
}
class Excep1
{
    static void Show(string a)
    {
        if(a!="COUPON123")
        {
            throw new InvalidCouponCode("Failed to apply coupon: Invalid Coupon Codey");
        }
        else
        {
            throw new InvalidCouponCode("Coupon code applied successfully");
        }
    }
   public static void Main(string[] args)
   {
    string a=args[0];

    try
    {
        Show(a);    
    }
    catch(InvalidCouponCode e)
    {
        Console.WriteLine(e.Message);
    }
    finally
    {
        Console.WriteLine("Coupon code applied successfully Thank you for shopping with us!!");
    }
   }

}