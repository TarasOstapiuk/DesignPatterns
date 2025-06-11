namespace DesignPatterns.Application.Behavioral.Visitor
{
  public class VisitorHandler
  {
    public string Handle()
    {
      var units = new List<ICombatUnit>
      {
         new Artillery(50, true ),
         new MortarTeam(10, true )
      };

      var inspector = new MaintenanceInspector();
      var result = string.Empty;

      foreach (var unit in units)
      {
        result += unit.Inspect( inspector );
      }

      return result;
    }
  }
}
