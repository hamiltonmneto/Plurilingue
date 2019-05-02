using Plurilingue.Domain.Entities;
using Plurilingue.Services.Interfaces;
using Plurilingue.Services.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plurilingue.Services.Services
{
    public class UserService : IUserService
    {

        public readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public long AddNewUser(User user)
        {
            _userRepository.Add(user);
            return 0;
        }
    }
}
