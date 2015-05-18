using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trivia.Core;
using System.Data.Entity;
using System.Linq;
using Trivia.Core.Entities;
using Trivia.DataAccess.EntityFramework;
using Trivia.DataAccess.EntityFramework.Repository;
using Trivia.TestData.TestObjects;
using Trivia.Core.Repository;

namespace Trivia.DataAccess.Tests.EntityFramework.Repository
{
    [TestClass]
    public class QuestionRepositoryTest : RepositoryTest<Question>
    {
        protected override IRepository<Question> GetRepository(TriviaDbContext dbContext)
        {
            return new QuestionRepository(dbContext);
        }

        protected override int GetAllCount()
        {
            return TestQuestion.Entities.Count();
        }

        [TestMethod]
        public override void Test_GetAll()
        {
            // This method must be here and call the base class because we can't have the [TestMethod] annotation on an inherited class.
            base.Test_GetAll();
        }
    }
}
