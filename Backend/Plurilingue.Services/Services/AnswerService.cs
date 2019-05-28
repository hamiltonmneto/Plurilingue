using Plurilingue.Domain.Entities;
using Plurilingue.Domain.Interfaces.Interfaces.Repositories;
using Plurilingue.Domain.Interfaces.Interfaces.Services;
using Plurilingue.Domain.Interfaces.Repositories;
using System.Linq;

namespace Plurilingue.Services.Services
{
    public class AnswerService : IAnswerService
    {
        public readonly IAnswerRepository _answerRepository;
        public readonly IUserRepository _userRepository;
        public AnswerService(IAnswerRepository answerRepository, IUserRepository userRepository)
        {
            _answerRepository = answerRepository;
            _userRepository = userRepository;
        }
        public void RegisterAnswer(Answer answer)
        {
            _answerRepository.Add(answer);
        }

        public void RegisterBestAnswer(long id)
        {
            var answer = _answerRepository.GetAnswerAndQuestionById(id);
            if (answer.Question.Answers.Any(x => x.IsBestAnswer == true))
                return;
            answer.IsBestAnswer = true;
            var user = _userRepository.GetById(answer.Question.User_Id);
            user.UserPoints += 1;
            _userRepository.Update(user);
            _answerRepository.Update(answer);
        }
    }
}
