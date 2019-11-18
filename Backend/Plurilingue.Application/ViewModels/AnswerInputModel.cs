using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plurilingue.Application.ViewModels
{
    public class AnswerInputModel
    {
        public long UserId { get; set; }
        public long QuestionId { get; set; }
        public string AnswerContent { get; set; }
    }
}
