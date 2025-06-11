namespace DesignPatterns.Application.Behavioral.Visitor
{
  public class MaintenanceInspector : IUnitVisitor
  {
    public string Visit( Artillery artillery )
    {
      if (artillery.IsServed && artillery.AmmoCount > 20)
      {
        return $"Inspecting howitzer: state is valid and ammo is anought. ";
      }

      return $"Inspecting howitzer: state is invalid or ammo is not anought. ";
    }

    public string Visit( MortarTeam mortar )
    {
      if (mortar.IsServed && mortar.AmmoCount > 30)
      {
        return $"Inspecting mortar: state is valid and ammo is anought. ";
      }

      return $"Inspecting mortar: state is invalid or ammo is not anought. ";
    }
  }
}
