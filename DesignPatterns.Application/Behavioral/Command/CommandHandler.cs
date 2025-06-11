namespace DesignPatterns.Application.Behavioral.Command
{
  public class CommandHandler
  {
    public string Handle()
    {      
      var fireArtillery = new FireCommand( new Mortar() );
      var reloadArtillery = new ReloadCommand( new Mortar() );

      var fireHowitzer = new FireCommand( new Howitzer() );
      var reloadHowitzer = new ReloadCommand( new Howitzer() );

      var invoker = new Commander();
      invoker.AddCommand( fireArtillery );
      invoker.AddCommand( reloadArtillery );
      invoker.AddCommand( fireHowitzer );
      invoker.AddCommand( reloadHowitzer );

      return invoker.ExecuteCommands();
    }
  }
}
