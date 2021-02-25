using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace Api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ChiboloController : ControllerBase
  {
    [HttpGet]
    public Object Get() => new { Name = "Chibolo Pecoso Castillo", Pareja = "Yoselin Gonzales", Hijos = new List<Object>() { new { Nombre = "Yoselino", ApellidoPaterno = "No tiene" } } };
  }
}