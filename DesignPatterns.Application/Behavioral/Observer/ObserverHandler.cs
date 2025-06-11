namespace DesignPatterns.Application.Behavioral.Observer
{
  public class ObserverHandler
  {
    public string Handle()
    {
      var artilery = new Artillery();

      artilery.UnderAttack += DispatchRepairTeam;

      var result = artilery.TakeDamage();

      return result;
    }

    private static string DispatchRepairTeam( object sender, UnderAttackEventArgs args )
    {
      return $"Repair team dispatches to: {args.UnitPosition}";
    }

  }
}
