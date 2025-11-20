using EkhayaMeals.Modules.Authentication.Application.Services;
using Microsoft.Extensions.DependencyInjection;
namespace EkhayaMeals.Modules.Authentication.Application;

public static class DependancyInjection
{
    public static IServiceCollection AddAuthenticationApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}