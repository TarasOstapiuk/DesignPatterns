namespace DesignPatterns.Application.Behavioral.Chains
{
  public class ChainHandler
  {
    public string Handle()
    {
      var car = new Car();
      var servicesChains =  CarServiceBase.Create()
        .AddChain( new TransmisionService() )
        .AddChain( new ChassisService() )
        .AddChain( new EngineService() );

      var carStatePreviousState = car.GetCarStateReport();
      servicesChains.Serve(car);
      var carStateAfterService = car.GetCarStateReport();

      var result = $"Before service car has status: {carStatePreviousState} " +
        $"After service car has status:{carStateAfterService}";

      return result;
    }
  }
}
