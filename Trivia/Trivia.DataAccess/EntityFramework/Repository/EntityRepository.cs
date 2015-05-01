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
    public class EntityRepository<T> : Repository<T>, IEntityRepository<T> where T : Entity
    {
        public EntityRepository(TriviaDbContext context) : base(context)
        {}

        public T GetById(int id)
        {
            return _DbContext.Set<T>().Find(id);
        }

        public void Delete(int id)
        {
            T entity = GetById(id);
            _DbContext.Set<T>().Remove(entity);
        }
    }
}
