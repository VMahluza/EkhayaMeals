namespace EkhayaMeals.Modules.Authentication.Contracts.Authentication.Requests;
public record RegisterRequest(
    string FirstName,
    string LastName,
    string Email,
    string Password
    );
