using Plurilingue.Domain.Entities;
using Plurilingue.Domain.Interfaces;
using Plurilingue.Domain.Interfaces.Repositories;
using Plurilingue.Infra.CrossCutting.Exceptions;
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
            if (_userRepository.GetUserByEmail(user).Any())
                throw new EmailJaCadastradoException();
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
    }
}
