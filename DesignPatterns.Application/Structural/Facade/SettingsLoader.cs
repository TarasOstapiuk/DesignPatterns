namespace DesignPatterns.Application.Structural.Facade
{
  public class SettingsLoader : IGameSystem
  {
    public string Initialize()
    {
      return "Settings started to load ";
    }

    public string Run()
    {
      return "Settings run! ";
    }
  }
}
