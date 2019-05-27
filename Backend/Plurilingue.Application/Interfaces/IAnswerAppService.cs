using Plurilingue.Application.ViewModels;

namespace Plurilingue.Application.Interfaces
{
    public interface IAnswerAppService
    {
        void RegisterAnswer(AnswerInputModel model);
        void RegisterBestAnswer(long id);
    }
}
