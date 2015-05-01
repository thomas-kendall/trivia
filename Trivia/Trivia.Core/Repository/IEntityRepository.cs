using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;

namespace Trivia.Core.Repository
{
    public interface IEntityRepository<T> : IRepository<T> where T : Entity
    {
        T GetById(int id);

        void Delete(int id);
    }
}
