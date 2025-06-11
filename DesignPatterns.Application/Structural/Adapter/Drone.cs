namespace DesignPatterns.Application.Structural.Adapter
{
  public class Drone : IFly
  {
    public string Fly()
    {
      return "Drone is flying";
    }
  }
}
