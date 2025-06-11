namespace DesignPatterns.Application.Structural.Facade
{
  public class FacadeHandler
  {
    public string Handle()
    {
      var launcher = new GameLauncher();
      var lounchingLogs = launcher.LaunchGame();
      var runnungLogs = launcher.RunGame();

      return lounchingLogs + "\n" + runnungLogs;
    }
  }
}
