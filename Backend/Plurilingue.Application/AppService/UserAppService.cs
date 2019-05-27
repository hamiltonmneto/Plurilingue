using AutoMapper;
using Plurilingue.Application.Interfaces;
using Plurilingue.Application.OutputModels;
using Plurilingue.Application.ViewModels;
using Plurilingue.Domain.Entities;
using Plurilingue.Domain.Interfaces;
using System.Collections.Generic;

namespace Plurilingue.Application.AppService
{
    public class UserAppService : IUserAppService
    {
        public readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserAppService(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public long AddNewUser(RegisterInputModel model)
            => _userService.AddNewUser(_mapper.Map<RegisterInputModel, User>(model));

        public UserOutputModel Authentication(LoginInput model) 
            => _mapper.Map<User, UserOutputModel>(_userService.Authentication(_mapper.Map<LoginInput, User>(model)));

        public List<UserOutputModel> GetTopUser()
            => _mapper.Map<List<User>, List<UserOutputModel>>(_userService.GetTopUsers());
    }
}
