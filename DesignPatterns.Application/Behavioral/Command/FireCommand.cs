namespace DesignPatterns.Application.Behavioral.Command
{
  public class FireCommand : ICommand
  {
    private WeaponBase _weapon;

    public FireCommand( WeaponBase weapon )
    {
      _weapon = weapon;
    }

    public string Execute()
    {
      return _weapon.Fire();
    }
  }
}
