using System;
using System.Collections.Generic;
using System.Text;

namespace Plurilingue.Domain.Entities
{
    public class Question : BaseEntity
    {
        public long User_Id { get; set; }
        public virtual User User { get; set; }
        public virtual List<Answer> Answers { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string TextContent { get; set; }
    }
}
