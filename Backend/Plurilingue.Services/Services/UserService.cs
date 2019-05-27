using Plurilingue.Domain.Entities;
using Plurilingue.Domain.Interfaces;
using Plurilingue.Domain.Interfaces.Repositories;
using Plurilingue.Infra.CrossCutting.Exceptions;
using Plurilingue.Infra.CrossCutting.Validations;
using System.Collections.Generic;
using System.Linq;

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
            if (!new EmailValidation().IsValidEmail(user.Email))
                throw new InvalidEmailException();
            if (_userRepository.GetUserByEmail(user).Any())
                throw new EmailJaCadastradoException();
            user.UserPoints = 0;
            _userRepository.Add(user);
            return user.Id;
        }

        public User Authentication(User user)
        {
            var dbUser = _userRepository.GetUserByEmail(user);
            if (!dbUser.Any())
                throw new EmailNaoCadastradoException();
            if (dbUser.FirstOrDefault().Password != user.Password)
                throw new IncorrectPasswordException();

            return dbUser.FirstOrDefault();
        }

        public List<User> GetTopUsers() 
            => _userRepository.GetAll().ToList();
    }
}
