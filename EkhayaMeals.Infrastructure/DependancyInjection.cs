using Microsoft.Extensions.DependencyInjection;
namespace EkhayaMeals.Modules.Authentication.Infrastructure;

public static class DependancyInjection
{
    public static IServiceCollection AddAuthenticationInfrastructure(this IServiceCollection services)
    {
        //services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}