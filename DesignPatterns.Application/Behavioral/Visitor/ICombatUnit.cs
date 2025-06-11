namespace DesignPatterns.Application.Behavioral.Visitor
{
  public interface ICombatUnit
  {
    string Inspect( IUnitVisitor visitor );
  }
}
