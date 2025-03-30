using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
  [ApiController]
  [Route( "[controller]" )]
  public class CreationalPatternsController : ControllerBase
  {
    private readonly ILogger<CreationalPatternsController> _logger;

    public CreationalPatternsController( ILogger<CreationalPatternsController> logger )
    {
      _logger = logger;
    }

    [HttpGet]
    public IEnumerable<bool> Get()
    {
      return new List<bool>{ true, false };
    }
  }
}
