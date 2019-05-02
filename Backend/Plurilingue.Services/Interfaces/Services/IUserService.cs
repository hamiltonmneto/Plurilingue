using Plurilingue.Domain.Entities;

namespace Plurilingue.Services.Interfaces
{
    public interface IUserService
    {
        long AddNewUser(User user);
    }
}
