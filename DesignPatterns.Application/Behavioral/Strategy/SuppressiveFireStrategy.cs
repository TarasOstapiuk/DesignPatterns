namespace DesignPatterns.Application.Behavioral.Strategy
{
  public class SuppressiveFireStrategy : IFiringStrategy
  {
    public string Fire( string coordinates )
    {
      return $"Provide suppressive fire at {coordinates} to block enemy movement. ";
    }
  }
}
