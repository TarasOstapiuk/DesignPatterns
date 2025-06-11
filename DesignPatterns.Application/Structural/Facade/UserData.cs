namespace DesignPatterns.Application.Structural.Facade
{
  public class UserData : IGameSystem
  {
    public string Initialize()
    {
      return "Started to load user data!";
    }

    public string Run()
    {
      return "User data runs!";
    }
  }
}
