namespace DesignPatterns.Application.Behavioral.State
{
  public abstract class ArtilleryState
  {
    public virtual string PrepareForFire( ArtilleryUnit unit )
    {
      return "Already ready to fire.";
    }

    public virtual string PrepareForTransport( ArtilleryUnit unit )
    {
      return "Already in transport mode.";
    }
  }
}
