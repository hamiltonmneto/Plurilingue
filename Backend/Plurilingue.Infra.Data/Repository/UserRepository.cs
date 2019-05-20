using Plurilingue.Domain.Entities;
using Plurilingue.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plurilingue.Infra.Data.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public IEnumerable<User> GetUserByEmail(User user)
        {
            return Db.User.Where(u => u.Email == user.Email);
        }
    }
}
