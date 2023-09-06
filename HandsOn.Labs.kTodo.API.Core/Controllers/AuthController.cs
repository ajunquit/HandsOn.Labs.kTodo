using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using HandsOn.Labs.kTodo.API.Core.Helpers;
using HandsOn.Labs.kTodo.Application.Dtos.Auth;
using HandsOn.Labs.kTodo.Application.Dtos.User;
using HandsOn.Labs.kTodo.Application.Interfaces.CQRS;
using HandsOn.Labs.kTodo.Transversal.Common.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace HandsOn.Labs.kTodo.API.Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController: ControllerBase
    {
        private readonly IUserQueryService _userQueryService;
        private readonly AppSettings _appSettings;

        public AuthController(IUserQueryService userQueryService,
            IOptions<AppSettings> appSettings)
        {
            this._userQueryService = userQueryService;
            this._appSettings = appSettings.Value;
        }
        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public IActionResult Authenticate(string user)
        {
            var response = _userQueryService.AuthenticateFake(user);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                {
                    response.Data.Token = BuildToken(response);
                    return Ok(response);
                }
                else
                    return NotFound(response);
            }

            return BadRequest(response);
        }

        private string BuildToken(Response<AuthDto> authDto)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, authDto.Data.User.Name) // fake
                }),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = _appSettings.Issuer,
                Audience = _appSettings.Audience
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return tokenString;
        }
    }
}
