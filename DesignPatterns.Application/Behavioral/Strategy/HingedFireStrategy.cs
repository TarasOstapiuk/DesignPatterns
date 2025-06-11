namespace DesignPatterns.Application.Behavioral.Strategy
{
  public class HingedFireStrategy : IFiringStrategy
  {
    public string Fire( string coordinates )
    {
      return $"Launching shells by hinged trajectory to {coordinates}. ";
    }
  }
}
