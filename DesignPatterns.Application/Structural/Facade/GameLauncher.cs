using System.Linq;

namespace DesignPatterns.Application.Structural.Facade
{
  public class GameLauncher
  {
    private readonly List<IGameSystem> _gameSystems;

    public GameLauncher()
    {
      _gameSystems = new List<IGameSystem>();
      _gameSystems.Add( new GraphicsEngine() );
      _gameSystems.Add( new SoundSystem() );
      _gameSystems.Add( new SettingsLoader() );
      _gameSystems.Add( new UserData() );
    }

    public string LaunchGame()
    {
      var loanchLogs = string.Join( "\n", _gameSystems.Select( x => x.Initialize() ) );
      return loanchLogs;
    }

    public string RunGame()
    {
      var runLogs = string.Join( "\n", _gameSystems.Select( x => x.Run() ) );
      return runLogs;
    }
  }
}
