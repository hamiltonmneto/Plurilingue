using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plurilingue.Application.ViewModels
{
    public class LoginInput
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
