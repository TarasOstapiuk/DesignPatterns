namespace DesignPatterns.Application.Structural.Proxy
{
  public class ProxyHandler
  {
    public string Handle()
    {
      var soldier = new ArtilleryMan(isTrained: true );
      var howitzer = new HowitzerProxy( soldier );
      howitzer.DeliverShells( 150 );

      var target = new Target("Buhanka with orks");
      target.IsScouted = true;
      target.ImportanceLevel = 3;

      var result = howitzer.Fire( target );
      return result;
    }
  }
}
