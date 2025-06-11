namespace DesignPatterns.Application.Behavioral.State
{
  public class StateHandler
  {
    public string Handle()
    {
      var unit = new ArtilleryUnit();

      var result = unit.PrepareForFire();
      result += unit.PrepareForTransport();
      result += unit.PrepareForTransport();

      return result;
    }
  }
}
