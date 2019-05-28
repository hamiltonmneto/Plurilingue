using System;
using System.Collections.Generic;
using System.Text;

namespace Plurilingue.Domain.Entities
{
    public class Answer : BaseEntity
    {
        public virtual Question Question { get; set; }
        public long Question_Id { get; set; }
        public string TextContent { get; set; }
        public bool IsBestAnswer { get; set; }
    }
}
