namespace DesignPatterns.Application.Structural.Flyweight
{
  public class FlyweightHandler
  {
    public string Handle()
    {
      var users = new List<User>
      {
        new User( "John Stark" ),
        new User( "John Snow" ),
        new User( "Rob Stark" )
      };

      var usersNames = string.Join( ", ", users.Select( x => x.FullName ) );

      var result = $"Users {usersNames} were created. And instead of creating {User.AllStringsHeavyWeightCount} strings system creates  {User.AllStringsFlyWeightCount} strings. And save memory.";

      return result ;
    }
  }
}
