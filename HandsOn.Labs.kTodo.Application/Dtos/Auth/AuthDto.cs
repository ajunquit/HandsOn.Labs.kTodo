using HandsOn.Labs.kTodo.Application.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.Application.Dtos.Auth
{
    public class AuthDto
    {
        public UserDto User { get; set; }
        public string Token { get; set; }
    }
}
