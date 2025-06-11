namespace DesignPatterns.Application.Behavioral.TemplateMethod
{
  public class TemplateMethodHandler
  {
    public string Handle()
    {
      var units = new List<CombatUnitBase>
      {
         new Artillery(),
         new MortarTeam()
      };

      var result = string.Empty;
      foreach (var unit in units)
      {
        result += unit.Act();
      }

      return result;
    }
  }
}
