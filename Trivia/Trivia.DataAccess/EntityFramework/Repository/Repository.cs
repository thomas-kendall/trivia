using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core;
using Trivia.Core.Repository;

namespace Trivia.DataAccess.EntityFramework.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected TriviaDbContext _DbContext { get; set; }

        public Repository(TriviaDbContext context)
        {
            this._DbContext = context;
        }

        public void Create(T entity)
        {
            _DbContext.Set<T>().Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _DbContext.Set<T>().AsEnumerable();
        }

        public void Update(T entity)
        {
            _DbContext.Entry<T>(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _DbContext.Set<T>().Remove(entity);
        }

        public void Save()
        {
            _DbContext.SaveChanges();
        }

        private bool _Disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this._Disposed)
            {
                if (disposing)
                {
                    _DbContext.Dispose();
                }
            }
            this._Disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
