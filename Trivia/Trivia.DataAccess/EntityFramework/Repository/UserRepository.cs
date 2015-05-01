using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;
using Trivia.Core.Repository;

namespace Trivia.DataAccess.EntityFramework.Repository
{
    public class UserRepository : EntityRepository<User>, IUserRepository
    {
        public UserRepository(TriviaDbContext context) : base(context)
        {

        }
    }
}
