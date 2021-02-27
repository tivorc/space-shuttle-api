using System;
using System.Collections.Generic;
using GraphQL;
using GraphQL.Types;
using GraphQL.Utilities;
using Space.Api.GraphQL.Types;
using Space.Domain.Entities;

namespace Space.Api.GraphQL
{
  public class SpaceQuery : ObjectGraphType
  {
    public SpaceQuery()
    {
      Field<NonNullGraphType<ListGraphType<NonNullGraphType<SpaceShuttleType>>>>(
        "spaceshuttles",
        resolve: context =>
        {
          try
          {
            return SpaceShuttle.GetAll();
          }
          catch (System.Exception e)
          {
            throw new ExecutionError(e.Message);
          }
        }
      );

    }
  }
}