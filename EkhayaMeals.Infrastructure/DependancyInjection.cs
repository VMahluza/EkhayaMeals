using EkhayaMeals.Modules.Authentication.Application.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
namespace EkhayaMeals.Modules.Authentication.Infrastructure;

public static class DependancyInjection
{
    public static IServiceCollection AddAuthenticationInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddSingleton<IJWTTokenGenerator, JwtTokenGenerator>();
        return services;
    }
}