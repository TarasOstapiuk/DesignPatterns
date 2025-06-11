using DesignPatterns.Application.Structural.Bridge.Abstracttions;

namespace DesignPatterns.Application.Structural.Bridge
{
  public class FastSpringOrder : OrderBase
  {
    public override decimal Price => 100m;

    public FastSpringOrder( ICoupon coupon)
      : base( coupon )
    {
    }

    public override string GeFinalPrice()
    {
      var price = Price - (Price * _coupon.CouponDiscount);

      return $"FastSpring provides order with discount {_coupon.CouponDiscount * 100}% and total price is {price}";
    }
  }
}
