
using EkhayaMeals.Modules.Authentication.Application.Common.Interfaces;
using EkhayaMeals.Modules.Authentication.Application.Services.Common;

namespace EkhayaMeals.Modules.Authentication.Application.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJWTTokenGenerator _jwtTokenGenerator;
    public AuthenticationService(IJWTTokenGenerator jWTTokenGenerator)
    {
        _jwtTokenGenerator = jWTTokenGenerator;
    }

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

        // Check if user already exists (omitted for brevity)

        // Create user (with unique id)
        Guid userId = Guid.NewGuid();

        // Generate JWT token
        string token =  _jwtTokenGenerator.GenerateTokenForUser(userId, FirstName, LastName, Email);

        AuthenticationResult authenticationResult = new AuthenticationResult(
            userId,
            FirstName,
            LastName,
            Email,
            token
        );

        return authenticationResult;
    }
}