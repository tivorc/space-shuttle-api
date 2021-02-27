using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Space.Domain.Entities;

namespace Space.Api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class SpaceShuttleController : ControllerBase
  {
    [HttpGet]
    public Task<IEnumerable<SpaceShuttle>> Get()
    {
      return SpaceShuttle.GetAll();
    }
  }
}
