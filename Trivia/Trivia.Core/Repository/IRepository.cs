using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.Core.Repository
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Create(T entity);

        IEnumerable<T> GetAll();

        void Update(T entity);

        void Delete(T entity);

        void Save();
    }
}
