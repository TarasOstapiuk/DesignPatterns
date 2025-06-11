namespace DesignPatterns.Application.Structural.Bridge.Abstracttions
{
  public abstract class OrderBase
  {
    public readonly ICoupon _coupon;

    public abstract decimal Price { get; }

    public OrderBase( ICoupon coupon )
    {
      _coupon = coupon;
    }

    public abstract string GeFinalPrice();
  }
}
