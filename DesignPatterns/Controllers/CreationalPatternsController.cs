using Microsoft.AspNetCore.Mvc;
using DesignPatterns.Application.Creational.Builder;
using DesignPatterns.Application.Creational.Builder.NotFluentBuilder;

namespace DesignPatterns.Api.Controllers
{
  [ApiController]
  [Route( "[controller]" )]
  public class CreationalPatternsController : ControllerBase
  {

    [HttpGet]
    public string Get()
    {
      var handler = new BuilderHandler();
      return handler.HandleAutoFixtureCreation();
    }
  }
}
