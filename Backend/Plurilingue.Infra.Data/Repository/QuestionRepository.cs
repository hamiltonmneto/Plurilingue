using Microsoft.EntityFrameworkCore;
using Plurilingue.Domain.Entities;
using Plurilingue.Domain.Interfaces.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plurilingue.Infra.Data.Repository
{
    public class QuestionRepository : RepositoryBase<Question>, IQuestionRepository
    {
        public Question GetById(long id)
        {
            var question = Db.Set<Question>()
                .Include(x => x.Answers)
                .Include(x => x.User)
                .Where(x => x.Id == id)
                .FirstOrDefault();
            //question.Answers = question.Answers.OrderByDescending(x => x.IsBestAnswer == true).ToList();
            question.Answers = Db.Set<Answer>().Include(x => x.User).OrderByDescending(x => x.IsBestAnswer == true).ToList();

            return question;
        }

        public override IEnumerable<Question> GetAll()
        {
            var questions = Db.Set<Question>().Include(x => x.User);
            return questions.ToList();
        }
    }
}
