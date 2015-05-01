using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trivia.Core;
using System.Data.Entity;
using System.Linq;
using Trivia.Core.Entities;
using Trivia.DataAccess.EntityFramework;
using Trivia.DataAccess.EntityFramework.Repository;

namespace Trivia.DataAccess.Tests.EntityFramework.Repository
{
    [TestClass]
    public class QuestionRepositoryTest
    {
        [TestMethod]
        public void Test_Create()
        {
            Database.SetInitializer<TriviaDbContext>(new DropCreateDatabaseAlways<TriviaDbContext>());
            int questionId = 0;
            string questionText = "Who invented the time machine?";
            

            // Test Create
            using (var dbContext = new TriviaDbContext())
            {
                using (var repository = new EntityRepository<Question>(dbContext))
                {
                    var entity = new Question
                    {
                        Text = questionText,
                    };
                    repository.Create(entity);
                    repository.Save();
                    questionId = entity.Id;
                }
            }
            // Verify Create
            using (var dbContext = new TriviaDbContext())
            {
                using (var repository = new EntityRepository<Question>(dbContext))
                {
                    var allEntities = repository.GetAll();
                    Assert.AreEqual(1, allEntities.Count());
                    var entity = allEntities.First();
                    Assert.AreEqual(questionText, entity.Text);
                }
            }
        }

        [TestMethod]
        public void Test_GetAll()
        {
        }
    }
}
