using Plurilingue.Domain.Entities;

namespace Plurilingue.Domain.Interfaces.Interfaces.Services
{
    public interface IAnswerService
    {
        void RegisterAnswer(Answer answer);
        void RegisterBestAnswer(long id);
    }
}
