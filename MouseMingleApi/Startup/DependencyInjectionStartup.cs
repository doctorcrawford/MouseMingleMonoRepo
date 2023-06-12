using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace MouseMingleApi.Startup;

public static class DependencyInjectionSetup
{
  public static IServiceCollection RegisterServices(this IServiceCollection services)
  {
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();

    services.AddControllers().AddNewtonsoftJson();

    services.AddAuthentication(options =>
                            {
                              options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                              options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                              options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                            })
                            .AddJwtBearer(options =>
                            {
                              options.SaveToken = true;
                              options.RequireHttpsMetadata = false;
                              options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                              {
                                ValidateIssuer = true,
                                ValidateAudience = true,
                                ValidAudience = "https://localhost:5001",
                                ValidIssuer = "https://localhost:5001",
                                ClockSkew = TimeSpan.Zero,
                                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("CrankItToHeckinHeck"))
                              };
                            });

    services.AddApiVersioning(opt =>
                                    {
                                      opt.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                                      opt.AssumeDefaultVersionWhenUnspecified = true;
                                      opt.ReportApiVersions = true;
                                      opt.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader(),
                                                                                      new HeaderApiVersionReader("x-api-version"),
                                                                                      new MediaTypeApiVersionReader("x-api-version"));
                                    });

    services.AddVersionedApiExplorer(setup =>
                                      {
                                          setup.GroupNameFormat = "'v'VVV";
                                          setup.SubstituteApiVersionInUrl = true;
                                      });

    services.ConfigureOptions<SwaggerConfiguration.ConfigureSwaggerOptions>();

    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();

    return services;
  }
}