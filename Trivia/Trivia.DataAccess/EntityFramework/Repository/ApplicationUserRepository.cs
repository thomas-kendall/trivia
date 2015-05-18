using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;
using Trivia.Core.Repository;

namespace Trivia.DataAccess.EntityFramework.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(TriviaDbContext context) : base(context)
        {
        }

        public ApplicationUser FindByEmail(string email)
        {
            return _DbContext.Users.SingleOrDefault(u => u.Email == email);
        }
    }
}
