using Plurilingue.Domain.Entities;
using Plurilingue.Domain.Interfaces.Interfaces.Repositories;
using Plurilingue.Domain.Interfaces.Interfaces.Services;
using System.Collections.Generic;

namespace Plurilingue.Services.Services
{
    public class QuestionService : IQuestionService
    {
        public readonly IQuestionRepository _questionRepository;
        public QuestionService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }
        public void AddNewQuestion(Question question)
        {
            _questionRepository.Add(question);
        }

        public IEnumerable<Question> GetQuestion() 
            => _questionRepository.GetAll();
    }
}
