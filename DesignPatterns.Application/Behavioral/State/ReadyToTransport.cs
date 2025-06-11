namespace DesignPatterns.Application.Behavioral.State
{
  public class ReadyToTransport : ArtilleryState
  {
    public ReadyToTransport()
    {
    }

    public override string PrepareForFire( ArtilleryUnit unit )
    {
      unit.State = new ReadyToFire();
      return "Deploying artillery to combat position...";
    }
  }
}
