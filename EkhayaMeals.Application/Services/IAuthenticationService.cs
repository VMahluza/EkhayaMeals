using EkhayaMeals.Modules.Authentication.Application.Services.Objects;

namespace EkhayaMeals.Modules.Authentication.Application.Services;

public interface IAuthenticationService
{
    AuthenticationResult Login(string Email, string Password);
    AuthenticationResult Register(string FirstName, string LastName, string Email, string Password);
}
