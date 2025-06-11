namespace DesignPatterns.Application.Behavioral.Chains
{
  public class Car
  {
    public NodeStateEnum Transmision { get; set; }

    public NodeStateEnum Chassis { get; set; }

    public NodeStateEnum Engine { get; set; }

    public string GetCarStateReport() =>
      $"{nameof( Transmision )} has state - {Transmision}. " +
      $"{nameof( Chassis )} has state - {Chassis}. " +
      $"{nameof( Engine )} has state - {Engine}. ";
  }
}
