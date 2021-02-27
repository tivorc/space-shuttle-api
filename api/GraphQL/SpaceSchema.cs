using System;
using GraphQL.Types;

namespace Space.Api.GraphQL
{
  public class SpaceSchema : Schema
  {
    public SpaceSchema(IServiceProvider provider) : base(provider)
    {
      Query = new SpaceQuery();
    }
  }
}