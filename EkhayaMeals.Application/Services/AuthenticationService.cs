
using EkhayaMeals.Modules.Authentication.Application.Services.Objects;

namespace EkhayaMeals.Modules.Authentication.Application.Services;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Login(string Email, string Password)
    {

        AuthenticationResult authenticationResult = new AuthenticationResult(
            Guid.NewGuid(),
            "Test",
            "User",
            Email,
            "ThisIsATestToken"
        );
        return authenticationResult;
    }

    public AuthenticationResult Register(string FirstName, string LastName, string Email, string Password)
    {
        AuthenticationResult authenticationResult = new AuthenticationResult(
            Guid.NewGuid(),
            FirstName,
            LastName,
            Email,
            "ThisIsATestToken"
        );

        return authenticationResult;
    }
}