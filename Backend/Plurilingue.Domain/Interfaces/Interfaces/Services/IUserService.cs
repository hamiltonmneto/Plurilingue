using Plurilingue.Domain.Entities;

namespace Plurilingue.Domain.Interfaces
{
    public interface IUserService
    {
        long AddNewUser(User user);
        User Authentication(User user);
    }
}
