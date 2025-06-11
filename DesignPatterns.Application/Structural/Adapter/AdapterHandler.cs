namespace DesignPatterns.Application.Structural.Adapter
{
  public class AdapterHandler
  {
    public string Handle()
    {
      string result = null;

      var artilery = new Artilery();
      var soldier = new Soldier( artilery );
      result = soldier.Shoot();

      var drone = new Drone();
      var adaptedDrone = new DroneToWeaponAdapter( drone );
      soldier.Weapon = adaptedDrone;
      result.Concat( soldier.Shoot() );

      return result;
    }
  }
}
