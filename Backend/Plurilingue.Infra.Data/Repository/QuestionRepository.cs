using Plurilingue.Domain.Entities;
using Plurilingue.Domain.Interfaces.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plurilingue.Infra.Data.Repository
{
    public class QuestionRepository : RepositoryBase<Question>, IQuestionRepository
    {
    }
}
