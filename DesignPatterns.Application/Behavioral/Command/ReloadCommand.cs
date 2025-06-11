namespace DesignPatterns.Application.Behavioral.Command
{
  public class ReloadCommand : ICommand
  {
    private WeaponBase _weapon;

    public ReloadCommand( WeaponBase weapon )
    {
      _weapon = weapon;
    }

    public string Execute()
    {
      return _weapon.Reload();
    }
  }
}
