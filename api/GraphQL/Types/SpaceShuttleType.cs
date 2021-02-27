using GraphQL.Types;
using Space.Domain.Entities;

namespace Space.Api.GraphQL.Types
{
  public class SpaceShuttleType : ObjectGraphType<SpaceShuttle>
  {
    public SpaceShuttleType()
    {
      Name = "SpaceShuttle";
      Field(t => t.UID).Name("uid");
      Field(t => t.Name);

    }
  }
}