using System;
using System.Collections.Generic;
using System.Text;

namespace Plurilingue.Domain.Entities
{
    public class Topic : BaseEntity
    {
        public User User { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string TextContent { get; set; }
    }
}
