namespace DesignPatterns.Application.Behavioral.Chains
{
  public class TransmisionService : CarServiceBase
  {
    public override void Serve(Car car )
    {
      car.Transmision = NodeStateEnum.Served;
      base.Serve(car );
    }
  }
}
