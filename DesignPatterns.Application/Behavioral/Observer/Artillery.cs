namespace DesignPatterns.Application.Behavioral.Observer
{
  public class Artillery
  {
    public event UnitEventHandler UnderAttack;
    public string TakeDamage()
    {
      var result = UnderAttack?.Invoke( this,
        new UnderAttackEventArgs { UnitPosition = "OSUV: Hortitsia; Coordinates - 55'13'145" } );

      return "Unit is under attack. " + result;
    }
  }
}
