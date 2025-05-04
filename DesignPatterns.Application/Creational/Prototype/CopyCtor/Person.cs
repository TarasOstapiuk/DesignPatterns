using System.Xml.Linq;

namespace DesignPatterns.Application.Creational.Prototype.CopyCtor
{
  public class Person
  {
    public string[] _names;

    public Address _address;

    public Person( string[] names, Address address )
    {
      _names = names;
      _address = address;
    }

    public Person( Person other )
    {
      _names = new string[other._names.Length];
      Array.Copy( other._names, _names, other._names.Length );
      _address = new Address ( other._address );
    }
  }
}
