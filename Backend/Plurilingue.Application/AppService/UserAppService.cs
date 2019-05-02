using AutoMapper;
using Plurilingue.Application.Interfaces;
using Plurilingue.Application.ViewModels;
using Plurilingue.Domain.Entities;
using Plurilingue.Services.Interfaces;
using System;

namespace Plurilingue.Application.AppService
{
    public class UserAppService : IUserAppService
    {
        public readonly IUserService _userService;
        public UserAppService(IUserService userService)
        {
            _userService = userService;
        }

        public long AddNewUser(RegisterInputModel model)
        {
            return _userService.AddNewUser(Mapper.Map<RegisterInputModel,User>(model));
            throw new NotImplementedException();
        }
    }
}
