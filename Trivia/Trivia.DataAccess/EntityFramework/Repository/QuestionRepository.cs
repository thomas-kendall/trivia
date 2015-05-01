using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core;
using Trivia.Core.Entities;
using Trivia.Core.Repository;

namespace Trivia.DataAccess.EntityFramework.Repository
{
    public class QuestionRepository : EntityRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(TriviaDbContext context) : base(context)
        {
        }
    }
}
