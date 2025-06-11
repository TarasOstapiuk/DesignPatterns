namespace DesignPatterns.Application.Behavioral.Command
{
  public class Mortar : WeaponBase
  {
    public Mortar() : base( "Mortar" ) { }

    public override string Fire()
    {
      return $"{Name} fired a heavy mine!";
    }

    public override string Reload()
    {
      return $"{Name} is reloading manually." ;
    }
  }
}
