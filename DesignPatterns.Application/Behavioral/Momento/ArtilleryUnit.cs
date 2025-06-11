namespace DesignPatterns.Application.Behavioral.Momento
{
  public class ArtilleryUnit
  {
    private int _shellCount;
    private List<AmmoState> _history = new List<AmmoState>();
    private int _currentState;

    public ArtilleryUnit( int initialShells )
    {
      _shellCount = initialShells;
      _history.Add( new AmmoState( _shellCount ) );
    }

    public AmmoState Fire( int amount )
    {
      _shellCount -= amount;
      if (_shellCount < 0)
      {
        _shellCount = 0;
      }

      var state = new AmmoState( _shellCount );
      _history.Add( state );
      ++_currentState;
      return state;
    }

    public void Restore( AmmoState state )
    {
      if (state != null)
      {
        _shellCount = state.ShellsCount;
        _history.Add( state );
        _currentState = _history.Count - 1;
      }
    }

    public AmmoState Undo()
    {
      if (_currentState > 0)
      {
        var state = _history[--_currentState];
        _shellCount = state.ShellsCount;
        return state;
      }
      return null;
    }

    public AmmoState Redo()
    {
      if (_currentState + 1 < _history.Count)
      {
        var state = _history[++_currentState];
        _shellCount = state.ShellsCount;
        return state;
      }
      return null;
    }

    public override string ToString()
    {
      return $"Shells counts is {_shellCount}. ";
    }
  }
}
