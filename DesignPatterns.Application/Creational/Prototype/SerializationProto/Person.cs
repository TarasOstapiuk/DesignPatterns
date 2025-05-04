namespace DesignPatterns.Application.Creational.Prototype.SerializationProto
{
  public class Person
  {
    public string[] Names { get; set; }

    public int Age { get; set; }

    public Address Address { get; set; }

    public Person( string[] names, int age, Address address )
    {
      Names = names;
      Age = age;
      Address = address;
    }
  }
}
