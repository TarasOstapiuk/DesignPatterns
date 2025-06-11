namespace DesignPatterns.Application.Behavioral.Command
{
  public class Commander
  {
    private List<ICommand> _commandQueue = new List<ICommand>();

    public void AddCommand( ICommand command )
    {
      _commandQueue.Add( command );
    }

    public string ExecuteCommands()
    {
      string result = string.Empty;
      foreach (var command in _commandQueue)
      {
        result += command.Execute();
      }

      return result;
    }
  }
}
