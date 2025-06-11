namespace DesignPatterns.Application.Behavioral.Strategy
{
  public class ArtilleryUnit
  {
    private IFiringStrategy _firingStrategy;

    public string SetFiringStrategy( IFiringStrategy strategy )
    {
      _firingStrategy = strategy;
      return $"FiringStrategy set to: {strategy.GetType().Name}. ";
    }

    public string FireOnTarget( string targetCoordinates )
    {
      if (_firingStrategy == null)
      {
        return "No firing strategy selected. " ;
      }

      return _firingStrategy.Fire( targetCoordinates );
    }
  }
}
