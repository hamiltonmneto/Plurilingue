using Plurilingue.Domain.Entities;
using Plurilingue.Domain.Interfaces.Interfaces.Repositories;
using Plurilingue.Domain.Interfaces.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plurilingue.Services.Services
{
    public class QuestionService : IQuestionService
    {
        public readonly IQuestionRepository _questionRepository;
        public QuestionService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }
        public long AddNewQuestion(Topic question)
        {
            _questionRepository.Add(question);
            return 0;
        }
    }
}
