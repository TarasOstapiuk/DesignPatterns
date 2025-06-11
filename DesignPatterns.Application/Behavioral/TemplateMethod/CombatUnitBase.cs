namespace DesignPatterns.Application.Behavioral.TemplateMethod
{
  public abstract class CombatUnitBase
  {
    public string Act()
    {
      var result = ReceiveOrders();
      result += MoveToPosition();
      result += PrepareWeaponSystem();

      return result;
    }

    private string ReceiveOrders()
    {
      return $"{this.GetType().Name} Unit received Order. ";
    }
    protected abstract string MoveToPosition();
    protected abstract string PrepareWeaponSystem();
  }
}
