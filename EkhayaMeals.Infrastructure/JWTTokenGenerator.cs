using EkhayaMeals.Modules.Authentication.Application.Common.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
namespace EkhayaMeals.Modules.Authentication.Infrastructure;


public class JWTTokenGenerator : IJWTTokenGenerator
{


    public string GenerateTokenForUser(Guid userId, string firstName, string lastName, string email)
    {
        string token = string.Empty;

        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ThisIsASecretKeyForJWTTokenGeneration")),
            SecurityAlgorithms.HmacSha256
        );

        List<Claim> claims = new List<Claim> 
        { 
            new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, firstName),
            new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
            new Claim(JwtRegisteredClaimNames.Email, email)

        };

        var securityToken = new JwtSecurityToken( 
            issuer: "EkhayaMeals",
            claims: claims,
            expires: DateTime.UtcNow.AddHours(1),
            signingCredentials: signingCredentials
        );

        return new JwtSecurityTokenHandler().WriteToken(securityToken);

    }
}
