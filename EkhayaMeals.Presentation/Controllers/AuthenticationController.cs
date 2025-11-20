using EkhayaMeals.Modules.Authentication.Application.Services;
using EkhayaMeals.Modules.Authentication.Contracts.Authentication.Requests;
using EkhayaMeals.Modules.Authentication.Contracts.Authentication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace EkhayaMeals.Presentation.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : Controller
{
    private readonly ILogger<AuthenticationController> _logger;
    private readonly IAuthenticationService _authService;

    public AuthenticationController(ILogger<AuthenticationController> logger, IAuthenticationService authService)
    {
        _logger = logger;
        _authService = authService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest registerRequest)
    {
        if (registerRequest == null)
            return BadRequest("Invalid register request.");
  
        var response = _authService.Register(
            registerRequest.FirstName,
            registerRequest.LastName,
            registerRequest.Email,
            registerRequest.Password
        );

        AuthenticationResponse authenticationResponse = new AuthenticationResponse(
            response.Id,
            response.FirstName,
            response.LastName,
            response.Email,
            response.Token
        );
        return Ok(authenticationResponse);
    }


    [HttpPost("login")] 
    public IActionResult Login(LoginRequest loginRequest)
    {
        if(loginRequest == null)
            return BadRequest("Invalid login request.");

        var response = _authService.Login(
            loginRequest.Email,
            loginRequest.Password
        );

        AuthenticationResponse authenticationResponse = new AuthenticationResponse(
            response.Id,
            response.FirstName,
            response.LastName,
            response.Email,
            response.Token
        );

        return Ok(authenticationResponse);
    }
}