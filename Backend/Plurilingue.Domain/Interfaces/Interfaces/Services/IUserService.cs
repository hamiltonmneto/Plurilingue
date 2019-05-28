using Plurilingue.Domain.Entities;
using System.Collections.Generic;

namespace Plurilingue.Domain.Interfaces
{
    public interface IUserService
    {
        long AddNewUser(User user);
        User Authentication(User user);
        List<User> GetTopUsers();
    }
}
