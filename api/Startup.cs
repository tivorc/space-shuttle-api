using GraphQL.Server;
using GraphQL.Validation.Complexity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Space.Api.GraphQL;

namespace Space.Api
{
  public class Startup
  {
    //readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
    public Startup(IConfiguration configuration, IWebHostEnvironment environment)
    {
      Configuration = configuration;
      Environment = environment;
    }

    public IConfiguration Configuration { get; }
    public IWebHostEnvironment Environment { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddCors(options =>
      {
        options.AddDefaultPolicy(
          builder =>
          {
            builder.WithOrigins("http://example.com").AllowAnyHeader()
                                        .AllowAnyMethod();
          });
      });

      services.AddControllers();
      services.AddSingleton<SpaceSchema>()
        .AddGraphQL((options, provider) =>
        {
          options.EnableMetrics = false;
          options.ComplexityConfiguration = new ComplexityConfiguration { MaxDepth = 15 };
        })
        .AddSystemTextJson(deserializerSettings => { }, serializerSettings => { })
        .AddGraphTypes(typeof(SpaceSchema));
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app)
    {
      if (Environment.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseHttpsRedirection();
      app.UseGraphQLPlayground();
      app.UseRouting();
      app.UseCors();

      app.UseGraphQL<SpaceSchema>("/graphql");

      app.UseAuthorization();
      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
