namespace DesignPatterns.Application.Behavioral.Visitor
{
  public class Artillery : ICombatUnit
  {
    public int Calibr => 155;
    public int AmmoCount { get; set; }
    public bool IsServed { get; set; }

    public Artillery( int ammoCount, bool isServed ) 
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
