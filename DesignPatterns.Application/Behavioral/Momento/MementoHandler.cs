namespace DesignPatterns.Application.Behavioral.Momento
{
  public class MementoHandler
  {
    public string Handle()
    {
      var mortar = new ArtilleryUnit( 10 );
      mortar.Fire( 3 );
      mortar.Fire( 2 );
      var report = mortar.ToString();

      mortar.Undo();
      report += $"After Undo 1: {mortar}";
      mortar.Undo();
      report += $"After Undo 2: {mortar}";
      mortar.Redo();
      report += $"After Redo: {mortar}";

      return report;
    }
  }
}
