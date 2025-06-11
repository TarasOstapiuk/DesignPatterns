namespace DesignPatterns.Application.Behavioral.Strategy
{
  public class StrategyHandler
  {
    public string Handle()
    {
      var unit = new ArtilleryUnit();
      var result = unit.FireOnTarget( "Sector 17-15" );

      result += unit.SetFiringStrategy( new DirectFireStrategy() );
      result += unit.FireOnTarget( "Sector 17-15" );

      result += unit.SetFiringStrategy( new HingedFireStrategy() );
      result += unit.FireOnTarget( "Sector 25-40" );

      result += unit.SetFiringStrategy( new SuppressiveFireStrategy() );
      result += unit.FireOnTarget( "Sector 41-95" );

      return result;
    }
  }
}
