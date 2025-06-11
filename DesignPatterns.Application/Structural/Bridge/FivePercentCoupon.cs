using DesignPatterns.Application.Structural.Bridge.Abstracttions;

namespace DesignPatterns.Application.Structural.Bridge
{
  public class FivePercentCoupon : ICoupon
  {
    public decimal CouponDiscount => 0.05m;
  }
}
