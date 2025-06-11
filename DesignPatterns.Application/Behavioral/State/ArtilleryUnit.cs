namespace DesignPatterns.Application.Behavioral.State
{
  public class ArtilleryUnit
  {
    public ArtilleryState State = new ReadyToTransport();

    public string PrepareForFire() => State.PrepareForFire( this );
    public string PrepareForTransport() => State.PrepareForTransport( this );
  }
}
