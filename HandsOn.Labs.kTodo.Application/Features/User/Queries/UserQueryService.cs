using AutoMapper;
using HandsOn.Labs.kTodo.Application.Dtos.Auth;
using HandsOn.Labs.kTodo.Application.Dtos.User;
using HandsOn.Labs.kTodo.Application.Interfaces.CQRS;
using HandsOn.Labs.kTodo.Application.Interfaces.Repositories;
using HandsOn.Labs.kTodo.Core.Mappers;
using HandsOn.Labs.kTodo.Transversal.Common.Responses;

namespace HandsOn.Labs.kTodo.Application.Features.UserFeatures.Queries
{
    public class UserQueryService: IUserQueryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserQueryService(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }
        // Todo: Implement original Authentication
        public Response<AuthDto> AuthenticateFake(string user)
        {
            var response = new Response<AuthDto>();
            if (user.Equals("admin"))
            {
                response.Data = new AuthDto();
                response.Data.User = new UserDto();
                response.Data.User.Name = user;
                //response.Data = _mapper.Map<AuthDto>(user);
                response.IsSuccess = true;
                response.Message = "Successful Authentication!";
            }
            return response;
        }

        public async Task<List<UserDto>> GetUsersAsync()
        {
            var collection = await _unitOfWork.Users.GetAllAsync();
            return collection.MapTo<List<UserDto>>();
        }
    }
}
