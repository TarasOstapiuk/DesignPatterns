namespace DesignPatterns.Application.Structural.Facade
{
  public class GraphicsEngine : IGameSystem
  {
    public string Initialize()
    {
      return "Graphics started to load. ";
    }

    public string Run()
    {
      return "Graphics run! ";
    }
  }
}
