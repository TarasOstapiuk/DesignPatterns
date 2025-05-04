using System.Text.Json;

namespace DesignPatterns.Application.Creational.Prototype.SerializationProto
{
  public static class PersonDeepCopyExtension
  {

    public static Person DeepCopy(this Person other )
    {
      var personString = JsonSerializer.Serialize( other );
      var copy = JsonSerializer.Deserialize<Person>( personString );
      return copy;
    }
  }
}
