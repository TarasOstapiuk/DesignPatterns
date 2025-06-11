namespace DesignPatterns.Application.Structural.Bridge
{
  public class BridgeHandler
  {
    public string Handle()
    {
      var noCoupon = new NoCoupon();
      var fivePercentCoupon = new FivePercentCoupon();
      var tenPercentCoupon = new TenPercentCoupon();

      var zuoraOrder = new ZuoraOrder( fivePercentCoupon );
      var fastSpringOrder = new FastSpringOrder( tenPercentCoupon );

      return zuoraOrder.GeFinalPrice() + " " + fastSpringOrder.GeFinalPrice();
    }
  }
}
