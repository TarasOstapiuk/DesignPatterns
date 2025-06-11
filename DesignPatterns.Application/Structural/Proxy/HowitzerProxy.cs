namespace DesignPatterns.Application.Structural.Proxy
{
  public class HowitzerProxy : IWeapon
  {
    private IWeapon _howitzer;
    private ArtilleryMan _soldier;
    private int _shellsCount = 10;

    public HowitzerProxy( ArtilleryMan soldier )
    {
      _soldier = soldier;
      _howitzer = new Howitzer();
    }

    public string Fire( Target target )
    {
      if (!_soldier.IsTrained)
      {
        return "Provide soldier training";
      }

      if ( !target.IsWorthFire( _shellsCount ))
      {
        return "Target is not scouted well or there is not anought shells";
      }

      return _howitzer.Fire( target );
    }

    public void DeliverShells( int shellsCount )
    {
      _shellsCount += shellsCount;
    }
  }

}
