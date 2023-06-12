using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace MouseMingleApi.Startup;

public static class SwaggerConfiguration
{
  public static WebApplication ConfigureSwagger(this WebApplication app)
  {
    var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

    if (app.Environment.IsDevelopment())
    {
    app.UseSwagger();
    app.UseSwaggerUI(options => 
    {
    foreach (var description in apiVersionDescriptionProvider.ApiVersionDescriptions)
        {
            options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
                description.GroupName.ToUpperInvariant());
        }
      });
    }
    else
    {
      app.UseHttpsRedirection();
    }
    return app;
  }
  public class ConfigureSwaggerOptions : IConfigureNamedOptions<SwaggerGenOptions>
  {
    private readonly IApiVersionDescriptionProvider _provider;
    public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider)
    {
        _provider = provider;
    }
    public void Configure(SwaggerGenOptions options)
    {
        foreach (var description in _provider.ApiVersionDescriptions)
        {
          options.SwaggerDoc(description.GroupName, CreateVersionInfo(description));
        }
    }
    public void Configure(string name, SwaggerGenOptions options)
    {
        Configure(options);
    }
    private OpenApiInfo CreateVersionInfo(ApiVersionDescription desc)
    {
      var info = new OpenApiInfo()
      {
          Title = ".NET Core (.NET 6) Web API",
          Version = desc.ApiVersion.ToString()
      };

      if (desc.IsDeprecated)
      {
        info.Description += " This API version has been deprecated. Please use one of the new APIs available from the explorer.";
      }

      return info;
    }
  }
}