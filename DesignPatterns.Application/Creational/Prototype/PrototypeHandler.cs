using DesignPatterns.Application.Creational.Prototype.CopyCtor;
using DesignPatterns.Application.Creational.Prototype.SerializationProto;

namespace DesignPatterns.Application.Creational.Prototype
{
  public class PrototypeHandler
  {
    public string Handle(string realization )
    {
      var realizationLowerCase = realization.ToLower();
      return realizationLowerCase switch
      {
        "copyctor" => new CopyCtorHandler().Handle(),
        "serializationcoping" => new SerializationCopierHandler().Handle(),
        _ => throw new Exception( "Not found" )
      };
    }
  }
}
