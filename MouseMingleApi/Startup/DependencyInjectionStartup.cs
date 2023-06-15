using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MouseMingleApi.Models;

namespace MouseMingleApi.Startup;

public static class DependencyInjectionSetup
{
  public static IServiceCollection RegisterServices(this IServiceCollection services, WebApplicationBuilder builder)
  {
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();

    services.AddControllers().AddNewtonsoftJson();
    ConfigurationManager configuration = builder.Configuration;

    services.AddIdentity<IdentityUser, IdentityRole>()
        .AddEntityFrameworkStores<MouseMingleApiContext>()
        .AddDefaultTokenProviders();

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
                                ValidAudience = configuration["JWT:ValidAudience"],
                                ValidIssuer = configuration["JWT:ValidIssuer"],
                                ClockSkew = TimeSpan.Zero,
                                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
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