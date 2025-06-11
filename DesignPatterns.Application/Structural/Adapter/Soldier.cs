namespace DesignPatterns.Application.Structural.Adapter
{
  public class Soldier
  {
    private IWeapon _weapon;
    public Soldier( IWeapon weapon )
    {
      _weapon = weapon;
    }
    public string Shoot()
    {
      return _weapon.Fire();
    }

    public IWeapon Weapon
    {
      set { _weapon = value; }
    }
  }
}
