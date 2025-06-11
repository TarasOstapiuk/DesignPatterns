namespace DesignPatterns.Application.Behavioral.Chains
{
  public class ChassisService : CarServiceBase
  {
    public override void Serve(Car car)
    {
      car.Chassis = NodeStateEnum.Diagnosed;
      base.Serve(car );
    }
  }
}
