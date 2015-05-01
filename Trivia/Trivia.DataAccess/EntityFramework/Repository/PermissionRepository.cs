using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;
using Trivia.Core.Repository;

namespace Trivia.DataAccess.EntityFramework.Repository
{
    public class PermissionRepository : EntityRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(TriviaDbContext context) : base(context)
        {
        }
    }
}
