namespace DesignPatterns.Application.Behavioral.Strategy
{
  public class DirectFireStrategy : IFiringStrategy
  {
    public string Fire( string coordinates )
    {
      return $"Firing directly at target coordinates: {coordinates}. ";
    }
  }
}
