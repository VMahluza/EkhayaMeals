using EkhayaMeals.Modules.Authentication.Application.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
namespace EkhayaMeals.Modules.Authentication.Infrastructure;

public static class DependancyInjection
{
    public static IServiceCollection AddAuthenticationInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IJWTTokenGenerator, JWTTokenGenerator>();
        return services;
    }
}