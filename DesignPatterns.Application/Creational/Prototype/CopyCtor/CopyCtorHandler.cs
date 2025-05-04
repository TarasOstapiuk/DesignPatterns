namespace DesignPatterns.Application.Creational.Prototype.CopyCtor
{
  public class CopyCtorHandler
  {
    public string Handle()
    {
      var person1 = new Person(
        new[] { "Jack", "Sparow" },
        new Address( "Sambirska", "Drohobych" ) );

      var person2 = new Person( person1 );
      person2._names = new[] { "John", "Stark" };
      person2._address = new Address( "Naykova", "Lviv" );

      var copingFailed =
        person1._names[0] == person2._names[0]
        || person1._names[1] == person2._names[1]
        || person1._address._street == person2._address._street
        || person1._address._city == person2._address._city;

      return copingFailed ? " CopyCtor failed" : "CopyCtor works fine";
    }
  }
}
