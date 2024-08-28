using System.Net;
using Application.DTOs;
using Application.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Supabase;

namespace WebApi.Controllers.Administration
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly Supabase.Client _client;
        private readonly ILogger<UserController> _logger;

        public UserController(Client client, ILogger<UserController> logger)
        {
            _client = client;
            _logger = logger;
        }

        [HttpPost("register")]
        public async Task<IResult> RegisterUser(UserRequestDto userRequest)
        {
            try
            {
                var sesions = await _client.Auth.SignUp(userRequest.Email, userRequest.Password);

                if (sesions == null)
                {
                    return Results.BadRequest("Unable to register");
                }

                var userResponse = new UserResponseDto
                {
                    AccessToken = sesions.AccessToken,
                    RefreshToken = sesions.RefreshToken,
                    ExpiresIn = sesions.ExpiresIn,
                    TokenType = sesions.TokenType
                };

                return Results.Ok(userResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unable to register");
                throw new RentMeException((int)HttpStatusCode.BadRequest, "Unable to register", "");
            }
        }

        [HttpPost("login")]
        public async Task<IResult> LoginUser(UserRequestDto userRequest)
        {
            try
            {
                var sesions = await _client.Auth.SignIn(userRequest.Email, userRequest.Password);
                if (sesions == null)
                {
                    return Results.BadRequest("Unable to login");
                }

                var userResponse = new UserResponseDto
                {
                    AccessToken = sesions.AccessToken,
                    RefreshToken = sesions.RefreshToken,
                    ExpiresIn = sesions.ExpiresIn,
                    TokenType = sesions.TokenType
                };

                return Results.Ok(userResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unable to login");
                throw new RentMeException((int)HttpStatusCode.BadRequest, "Unable to login", "");
            }
        }

        [HttpPost("logout")]
        public async Task<IResult> Logout()
        {
            try
            {
                await _client.Auth.SignOut();

                return Results.Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unable to logout");
                throw new RentMeException((int)HttpStatusCode.BadRequest, "Unable to logout", "");
            }
        }
    }
}
