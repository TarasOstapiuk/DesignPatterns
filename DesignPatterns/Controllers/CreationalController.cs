using DesignPatterns.Application.Creational.Builder;
using DesignPatterns.Application.Creational.Factories;
using DesignPatterns.Application.Creational.Prototype;
using DesignPatterns.Application.Creational.Singleton;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Api.Controllers
{
  [ApiController]
  [Route( "/api/v1/patterns/[controller]" )]
  public class CreationalController : ControllerBase
  {

    [HttpGet( "builder" )]
    public string GetBuilder([FromQuery] string realization)
    {
      return new BuilderHandler().Handle( realization );
    }

    [HttpGet( "factory" )]
    public string GetFactory()
    {
      return new FactoryHandler().Handle();
    }

    [HttpGet( "prototype" )]
    public string GetPrototype( [FromQuery] string realization )
    {
      return new PrototypeHandler().Handle( realization );
    }

    [HttpGet( "singleton" )]
    public string GetSingleton( [FromQuery] string realization )
    {
      return new SingletonHandler().Handle( realization );
    }
  }
}
