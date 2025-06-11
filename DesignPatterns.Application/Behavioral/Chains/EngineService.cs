namespace DesignPatterns.Application.Behavioral.Chains
{
  public class EngineService : CarServiceBase
  {
    public override void Serve(Car car )
    {
      car.Engine = NodeStateEnum.Repaired;
      base.Serve(car );
    }
  }
}
