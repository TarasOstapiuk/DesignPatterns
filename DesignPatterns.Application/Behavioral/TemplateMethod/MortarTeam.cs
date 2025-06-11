namespace DesignPatterns.Application.Behavioral.TemplateMethod
{
  public class MortarTeam : CombatUnitBase
  {  
    protected override string MoveToPosition()
    {
      return "Mortar Team: move on foot to hilltop. ";
    }

    protected override string PrepareWeaponSystem()
    {
      return "Mortar Team: Assembling tube and adjusting baseplate. ";
    }
  }
}
