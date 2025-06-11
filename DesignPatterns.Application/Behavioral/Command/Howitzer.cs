namespace DesignPatterns.Application.Behavioral.Command
{
  public class Howitzer : WeaponBase
  {
    public Howitzer() : base( "Howitzer" ) { }

    public override string Fire()
    {
      return $"{Name} launched an explosive shell!";
    }

    public override string Reload()
    {
      return $"{Name} is being reloaded automationaly.";
    }
  }
}
