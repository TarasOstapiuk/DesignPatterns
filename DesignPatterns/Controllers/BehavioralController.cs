using DesignPatterns.Application.Behavioral.Chains;
using DesignPatterns.Application.Behavioral.Command;
using DesignPatterns.Application.Behavioral.Iterator;
using DesignPatterns.Application.Behavioral.Mediator;
using DesignPatterns.Application.Behavioral.Momento;
using DesignPatterns.Application.Behavioral.Observer;
using DesignPatterns.Application.Behavioral.State;
using DesignPatterns.Application.Behavioral.Strategy;
using DesignPatterns.Application.Behavioral.TemplateMethod;
using DesignPatterns.Application.Behavioral.Visitor;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Api.Controllers
{
  [ApiController]
  [Route( "/api/v1/patterns/[controller]" )]
  public class BehavioralController : ControllerBase
  {

    [HttpGet( "chain" )]
    public string GetChain()
    {
      var handler = new ChainHandler();
      return handler.Handle();
    }

    [HttpGet( "command" )]
    public string GetCommand()
    {
      var handler = new CommandHandler();
      return handler.Handle();
    }

    [HttpGet( "iterator" )]
    public string GetIterator()
    {
      var handler = new IteratorHandler();
      return handler.Handle();
    }

    [HttpGet( "mediator" )]
    public string GetMediator()
    {
      var handler = new MediatorHandler();
      return handler.Handle();
    }

    [HttpGet( "memento" )]
    public string GetMemento()
    {
      var handler = new MementoHandler();
      return handler.Handle();
    }

    [HttpGet( "observer" )]
    public string GetObserver()
    {
      var handler = new ObserverHandler();
      return handler.Handle();
    }

    [HttpGet( "state" )]
    public string GetState()
    {
      var handler = new StateHandler();
      return handler.Handle();
    }

    [HttpGet( "strategy" )]
    public string GetStrategy()
    {
      var handler = new StrategyHandler();
      return handler.Handle();
    }

    [HttpGet( "templatemethod" )]
    public string GetTemplateMethod()
    {
      var handler = new TemplateMethodHandler();
      return handler.Handle();
    }

    [HttpGet( "visitor" )]
    public string GetVisitor()
    {
      var handler = new VisitorHandler();
      return handler.Handle();
    }
  }
}
