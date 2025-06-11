using DesignPatterns.Application.Structural.Bridge.Abstracttions;

namespace DesignPatterns.Application.Structural.Bridge
{
  public class TenPercentCoupon : ICoupon
  {
    public decimal CouponDiscount => 0.1m;
  }
}
