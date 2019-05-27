using Plurilingue.Domain.Entities;
using Plurilingue.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plurilingue.Domain.Interfaces.Interfaces.Repositories
{
    public interface IQuestionRepository : IRepositoryBase<Question>
    {
        Question GetById(long id);
    }
}
