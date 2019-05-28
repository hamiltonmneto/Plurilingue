using Plurilingue.Domain.Entities;
using Plurilingue.Domain.Interfaces.Repositories;

namespace Plurilingue.Domain.Interfaces.Interfaces.Repositories
{
    public interface IAnswerRepository : IRepositoryBase<Answer>
    {
        Answer GetAnswerAndQuestionById(long id);
    }
}
