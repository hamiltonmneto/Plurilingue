using Plurilingue.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plurilingue.Domain.Interfaces.Interfaces.Services
{
    public interface IQuestionService
    {
        void AddNewQuestion(Question question);
        IEnumerable<Question> GetQuestion();
    }
}
