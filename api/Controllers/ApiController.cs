using System;
using Microsoft.AspNetCore.Mvc;


namespace Space.Api.Controllers
{
  [ApiController]
  [Route("api")]
  public class ApiController : ControllerBase
  {
    [HttpGet]
    public Object Get() => new { Name = "Space Shuttle API", Version = 1 };
  }
}
