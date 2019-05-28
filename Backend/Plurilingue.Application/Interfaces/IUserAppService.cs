using Plurilingue.Application.OutputModels;
using Plurilingue.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plurilingue.Application.Interfaces
{
    public interface IUserAppService
    {
        long AddNewUser(RegisterInputModel model);
        UserOutputModel Authentication(LoginInput model);
        List<UserOutputModel> GetTopUser();
    }
}
