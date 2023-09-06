using FluentValidation;
using HandsOn.Labs.kTodo.Application.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.Application.Validators
{
    public class UserDtoValidator: AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(u => u.Name).NotNull().NotEmpty();
        }
    }
}
