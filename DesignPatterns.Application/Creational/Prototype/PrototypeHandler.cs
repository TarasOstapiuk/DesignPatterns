using DesignPatterns.Application.Creational.Prototype.CopyCtor;
using DesignPatterns.Application.Creational.Prototype.SerializationProto;

namespace DesignPatterns.Application.Creational.Prototype
{
  public class PrototypeHandler
  {
    public string HandlerCopyCtor()
    {
      var result = new CopyCtorHandler().Handle();
      return result;
    }

    public string HandleSerializationCoping()
    {
      var result = new SerializationCopierHandler().Handle();
      return result;
    }
  }
}
