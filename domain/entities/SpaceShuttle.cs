using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Space.Domain.Entities
{
  public class SpaceShuttle
  {
    public Guid UID { get; set; } = Guid.NewGuid();
    public string Name { get; set; }

    public static async Task<IEnumerable<SpaceShuttle>> GetAll()
    {
      var list = new List<SpaceShuttle>(){
        new SpaceShuttle() { Name = "Columbia"},
        new SpaceShuttle() { Name = "Challenger"},
        new SpaceShuttle() { Name = "Discovery"},
        new SpaceShuttle() { Name = "Atlantis"},
        new SpaceShuttle() { Name = "Endeavor"},
        new SpaceShuttle() { Name = "Enterprise"}
      };
      return await Task.FromResult<List<SpaceShuttle>>(list);
    }
  }
}
