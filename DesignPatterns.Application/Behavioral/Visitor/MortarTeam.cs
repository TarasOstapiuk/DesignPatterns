namespace DesignPatterns.Application.Behavioral.Visitor
{
  public class MortarTeam : ICombatUnit
  {
    public int Calibr => 120;
    public int AmmoCount { get; set; }
    public bool IsServed {  get; set; }

    public MortarTeam( int ammoCount, bool isServed )
    {
      AmmoCount = ammoCount;
      IsServed = isServed;
    }

    public string Inspect( IUnitVisitor inspector )
    {
      return inspector.Visit( this );
    }
  }
}
