using System.Text;

namespace DesignPatterns.Application.Behavioral.Mediator
{
  public class ChatRoom
  {
    private List<Person> _people = new List<Person>();
    public StringBuilder _chatLog = new();


    public void SayToAllAndLog( string source, string msg )
    {
      _chatLog.AppendLine( $"{source} said all {msg} " );
      SayToAll( source, msg );
    }

    private void SayToAll( string source, string msg )
    {;
      foreach (var p in _people)
      {
        if (p._name != source)
        {
          p.Receive( source, msg );
        }
      }
    }

    public void Join( Person p )
    {
      string joinMsg = $"[Technical msg] {p._name} joins the chat";
      SayToAll( "ChatRoom", joinMsg );
      _chatLog.AppendLine( $"{joinMsg}");
      p._room = this;
      _people.Add( p );
    }

    public void Message( string source, string destination, string msg )
    {
      var address = _people
        .FirstOrDefault( p => p._name == destination );
      if(address is not null)
      {
        address.Receive( source, msg );
        _chatLog.AppendLine( $"{source} said {destination} {msg} "  );
      }
    }

    public string GetFullLog()
    {
      return _chatLog.ToString();
    }
  }

}
