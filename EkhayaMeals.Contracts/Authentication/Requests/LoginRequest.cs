namespace EkhayaMeals.Modules.Authentication.Contracts.Authentication.Requests;
public record LoginRequest(
    string Email,
    string Password
    );