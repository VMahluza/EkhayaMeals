namespace EkhayaMeals.Modules.Authentication.Application.Common.Interfaces;
public interface IJWTTokenGenerator
{
    string GenerateTokenForUser(Guid userId, string firstName, string lastName, string email);
}

