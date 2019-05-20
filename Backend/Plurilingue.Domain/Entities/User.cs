﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Plurilingue.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public long UserPoints { get; set; }
    }
}
