namespace EkhayaMeals.Modules.Authentication.Contracts.Authentication.Responses;
public record AuthenticationResponse (
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token
    );