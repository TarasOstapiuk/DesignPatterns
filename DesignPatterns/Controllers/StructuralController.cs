using DesignPatterns.Application.Structural.Adapter;
using DesignPatterns.Application.Structural.Bridge;
using DesignPatterns.Application.Structural.Composite;
using DesignPatterns.Application.Structural.Decorator;
using DesignPatterns.Application.Structural.Facade;
using DesignPatterns.Application.Structural.Flyweight;
using DesignPatterns.Application.Structural.Proxy;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Api.Controllers
{
  namespace DesignPatterns.Api.Controllers
  {
    [ApiController]
    [Route( "/api/v1/patterns/[controller]" )]
    public class StructuralController : ControllerBase
    {

      [HttpGet( "adapter" )]
      public string GetAdapter()
      {
        var handler = new AdapterHandler();
        return handler.Handle();
      }

      [HttpGet( "bridge" )]
      public string GetBridge()
      {
        var handler = new BridgeHandler();
        return handler.Handle();
      }

      [HttpGet( "composite" )]
      public string GetComposite()
      {
        var handler = new CompositeHandler();
        return handler.Handle();
      }

      [HttpGet( "decorator" )]
      public string GetDecorator()
      {
        var handler = new DecoratorHandler();
        return handler.Handle();
      }

      [HttpGet( "facade" )]
      public string GetFacade()
      {
        var handler = new FacadeHandler();
        return handler.Handle();
      }

      [HttpGet( "flyweight" )]
      public string GetFlyweight()
      {
        var handler = new FlyweightHandler();
        return handler.Handle();
      }

      [HttpGet( "proxy" )]
      public string GetProxy()
      {
        var handler = new ProxyHandler();
        return handler.Handle();
      }
    }
  }
}
