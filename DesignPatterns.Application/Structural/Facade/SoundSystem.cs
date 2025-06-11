namespace DesignPatterns.Application.Structural.Facade
{
  public class SoundSystem : IGameSystem
  {
    public string Initialize()
    {
      return "Sounds started to load. ";
    }

    public string Run()
    {
      return "Sounds run! ";
    }
  }
}
