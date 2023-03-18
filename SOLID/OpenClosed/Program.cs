// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

OrderManager orderManager = new OrderManager();
var price = orderManager.GetDiscountedPrice(1000, new CouponB());
Console.WriteLine(price);

public interface ICoupon
{
    double GetDiscounted(double totalPrice);
}

public class CouponA : ICoupon
{
    public double GetDiscounted(double totalPrice)
    {
        return totalPrice * .95;
    }
}

public class CouponB : ICoupon
{
    public double GetDiscounted(double totalPrice)
    {
        return totalPrice * .90;
    }
}

public class CouponC : ICoupon
{
    public double GetDiscounted(double totalPrice)
    {
        return totalPrice * .8;
    }
}

public class OrderManager
{

    public double GetDiscountedPrice(double totalPrice, ICoupon couponCode)
    {

        return couponCode.GetDiscounted(totalPrice);
        //switch (couponCode)
        //{

        //    case "A":
        //        totalPrice *= .95;
        //        break;
        //    case "B":
        //        totalPrice *= .90;

        //        break;
        //    case "C":
        //        totalPrice *= .85;
        //        break;


        //    default:
        //        break;
        //}

        //return totalPrice;
    }
}