namespace DesignPatterns.Application.Behavioral.Mediator
{
  public class Person
  {
    public string _name;
    public ChatRoom _room;

    public Person( string name )
    {
      _name = name;
    }

    public string Receive( string sender, string message )
    {
      string senderWithMessage = $"{sender}: '{message}'";
      return $"{_name}'s chat session: {senderWithMessage}";
    }

    public void SayToAll( string message )
    {
      _room.SayToAllAndLog( _name, message );
    }

    public void PrivateMessage( string destination, string message )
    {
      _room.Message( _name, destination, message );
    }
  }
}
