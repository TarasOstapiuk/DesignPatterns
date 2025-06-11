namespace DesignPatterns.Application.Behavioral.Command
{
  public abstract class WeaponBase
  {
    public string Name { get; set; }

    protected WeaponBase( string name )
    {
      Name = name;
    }

    public abstract string Fire();
    public abstract string Reload();
  }
}
