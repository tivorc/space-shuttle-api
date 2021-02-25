using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Space.Domain;

namespace Api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class SpaceShuttleController : ControllerBase
  {
    private readonly ILogger<SpaceShuttleController> _logger;

    public SpaceShuttleController(ILogger<SpaceShuttleController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public IEnumerable<SpaceShuttle> Get()
    {
      var list = new List<SpaceShuttle>(){
        new SpaceShuttle() {UID = System.Guid.NewGuid().ToString(), Name = "Columbia"},
        new SpaceShuttle() {UID = System.Guid.NewGuid().ToString(), Name = "Challenger"},
        new SpaceShuttle() {UID = System.Guid.NewGuid().ToString(), Name = "Discovery"},
        new SpaceShuttle() {UID = System.Guid.NewGuid().ToString(), Name = "Atlantis"},
        new SpaceShuttle() {UID = System.Guid.NewGuid().ToString(), Name = "Endeavor"},
        new SpaceShuttle() {UID = System.Guid.NewGuid().ToString(), Name = "Enterprise"}
      };
      return list;
    }
  }
}
