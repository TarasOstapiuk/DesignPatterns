namespace DesignPatterns.Application.Behavioral.TemplateMethod
{
  public class Artillery : CombatUnitBase
  {
    protected override string MoveToPosition()
    {
      return "Artillery: Moving by truck to firing position. ";
    }

    protected override string PrepareWeaponSystem()
    {
      return "Artillery: Praise the aim and aligning barrel. ";
    }
  }
}
