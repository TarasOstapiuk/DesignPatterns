namespace DesignPatterns.Application.Behavioral.Momento
{
  public class AmmoState
  {
    public int ShellsCount { get; }

    public AmmoState( int shells )
    {
      ShellsCount = shells;
    }
  }
}
