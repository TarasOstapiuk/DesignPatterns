using DesignPatterns.Application.Structural.Bridge.Abstracttions;

namespace DesignPatterns.Application.Structural.Bridge
{
  public class NoCoupon : ICoupon
  {
    public decimal CouponDiscount => 0;
  }
}
