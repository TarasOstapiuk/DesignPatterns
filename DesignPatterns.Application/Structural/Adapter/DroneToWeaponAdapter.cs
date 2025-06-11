namespace DesignPatterns.Application.Structural.Adapter
{
  public class DroneToWeaponAdapter : IWeapon
  {
    private readonly IFly _drone;
    public DroneToWeaponAdapter( IFly drone )
    {
      _drone = drone;
    }

    public string Fire()
    {
      return _drone.Fly() + " " + " and kills orks";
    }
  }
}
