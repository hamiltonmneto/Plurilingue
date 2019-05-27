using Microsoft.EntityFrameworkCore;
using Plurilingue.Domain.Entities;
using Plurilingue.Domain.Interfaces.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plurilingue.Infra.Data.Repository
{
    public class AnswerRepository : RepositoryBase<Answer>, IAnswerRepository
    {
        public Answer GetAnswerAndQuestionById(long id) 
            => Db.Set<Answer>()
                .Include(a => a.Question)
                .Where(x => x.Id == id)
                .FirstOrDefault();
    }
}
