using System.Text.Json;

namespace DesignPatterns.Application.Creational.Prototype.SerializationProto
{
  public class SerializationCopierHandler
  {

    public string Handle()
    {
      var person1 = new Person(
        new[] { "Jack", "Sparow" },
        33,
        new Address( "Sambirska", "Drohobych" ) );

      var person2 = person1.DeepCopy();
      person2.Names = new[] { "John", "Stark" };
      person2.Age = 35;
      person2.Address = new Address( "Naykova", "Lviv" );

      var copingFailed =
        person1.Names[0] == person2.Names[0]
        || person1.Names[1] == person2.Names[1]
        || person1.Age == person2.Age
        || person1.Address.Street == person2.Address.Street
        || person1.Address.City == person2.Address.City;

      return copingFailed ? " Serialization coping failed" : "Serialization coping works fine";
    }
  }
}
