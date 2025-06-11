namespace DesignPatterns.Application.Structural.Proxy
{
  public class Howitzer : IWeapon
  {
    public string Fire(Target target)
    {
      return $"Howitzer fire on {target.Name}.";
    }
  }
}
