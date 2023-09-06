using HandsOn.Labs.kTodo.Application.Dtos.Board;
using HandsOn.Labs.kTodo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.Application.Dtos.User
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<BoardDto> Boards { get; set; }
    }
}
