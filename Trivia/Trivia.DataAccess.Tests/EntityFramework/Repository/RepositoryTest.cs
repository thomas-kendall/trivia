using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Repository;
using Trivia.DataAccess.EntityFramework;
using Trivia.DataAccess.EntityFramework.Repository;
using Trivia.TestData;

namespace Trivia.DataAccess.Tests.EntityFramework.Repository
{
    public abstract class RepositoryTest<T> where T : class
    {
        public RepositoryTest()
        {
            Database.SetInitializer<TriviaDbContext>(new TestDataInitializer());
        }

        protected abstract IRepository<T> GetRepository(TriviaDbContext dbContext);

        protected abstract int GetAllCount();

        public virtual void Test_GetAll()
        {
            using (var dbContext = new TriviaDbContext())
            {
                // Verify that GetAll() works
                using (var repository = GetRepository(dbContext))
                {
                    var allEntities = repository.GetAll();
                    Assert.AreEqual(GetAllCount(), allEntities.Count());
                }
            }
        }
    }
}
