namespace DesignPatterns.Application.Behavioral.Mediator
{
  public class MediatorHandler
  {
    public string Handle()
    {
      var room = new ChatRoom();

      var igor = new Person( "Igor" );
      var taras = new Person( "Taras" );

      room.Join( igor );
      room.Join( taras );

      igor.SayToAll( "hi all" );
      taras.SayToAll( "hello Igor" );

      var yura = new Person( "Yura" );
      room.Join( yura );
      yura.SayToAll( "hi everyone!" );

      yura.PrivateMessage( "Taras", "don't write bad code!" );
      return room.GetFullLog();
    }
  }
}
