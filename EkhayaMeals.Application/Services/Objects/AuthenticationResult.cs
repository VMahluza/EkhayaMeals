namespace EkhayaMeals.Modules.Authentication.Application.Services.Objects;
public record AuthenticationResult(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token
    );
