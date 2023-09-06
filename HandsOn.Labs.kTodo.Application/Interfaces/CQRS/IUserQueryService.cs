using HandsOn.Labs.kTodo.Application.Dtos.Auth;
using HandsOn.Labs.kTodo.Application.Dtos.User;
using HandsOn.Labs.kTodo.Transversal.Common.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.Application.Interfaces.CQRS
{
    public interface IUserQueryService
    {
        public Task<List<UserDto>> GetUsersAsync();
        public Response<AuthDto> AuthenticateFake(string user);
    }
}
