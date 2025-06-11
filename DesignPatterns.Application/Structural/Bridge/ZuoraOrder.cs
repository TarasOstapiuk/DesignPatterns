using DesignPatterns.Application.Structural.Bridge.Abstracttions;

namespace DesignPatterns.Application.Structural.Bridge
{
  public class ZuoraOrder : OrderBase
  {
    public ZuoraOrder(ICoupon coupon) 
      : base( coupon )
    {
    }

    public override decimal Price => 50m;

    public override string GeFinalPrice()
    {
      var price = Price - (Price * _coupon.CouponDiscount);

      return $"Zuora provides order with discount {_coupon.CouponDiscount * 100}% and total price is {price}";
    }
  }
}
