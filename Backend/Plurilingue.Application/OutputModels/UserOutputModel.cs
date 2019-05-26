using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plurilingue.Application.OutputModels
{
    public class UserOutputModel
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public long UserPoints { get; set; }
    }
}
