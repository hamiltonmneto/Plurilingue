using Plurilingue.Domain.Entities;
using System.Collections.Generic;

namespace Plurilingue.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        IEnumerable<User> GetUserByEmail(User user);
    }
}
