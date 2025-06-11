namespace DesignPatterns.Application.Behavioral.State
{
  public class ReadyToFire : ArtilleryState
  {
    public ReadyToFire()
    {     
    }

    public override string PrepareForTransport( ArtilleryUnit unit )
    {
      unit.State = new ReadyToTransport();
      return "Folding artillery and preparing for transport.";
    }
  }
}
