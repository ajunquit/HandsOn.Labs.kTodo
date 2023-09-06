using HandsOn.Labs.kTodo.Application.Dtos.User;
using HandsOn.Labs.kTodo.Application.Interfaces.CQRS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HandsOn.Labs.Todo.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        private readonly IUserQueryService _userQueryService;

        public UserController(ILogger<UserController> logger, IUserQueryService userQueryService)
        {
            _logger = logger;
            this._userQueryService = userQueryService;
        }

        [HttpGet(Name = "GetUsers")]
        public async Task<List<UserDto>> Get()
        {
            return await _userQueryService.GetUsersAsync();
        }
    }
}