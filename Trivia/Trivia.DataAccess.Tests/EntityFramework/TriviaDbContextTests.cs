using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using System.Linq;
using Trivia.Core.Entities;
using Trivia.DataAccess.EntityFramework;


namespace Trivia.DataAccess.Tests.EntityFramework
{
    [TestClass]
    public class TriviaDbContextTests
    {
        [TestMethod]
        public void TestDataAccess()
        {
            Database.SetInitializer<TriviaDbContext>(new DropCreateDatabaseAlways<TriviaDbContext>());

            using (var db = new TriviaDbContext())
            {
                // Write the data
                var question = new Question
                {
                    Text = "Who invented the time machine?",
                };
                var answer = new Answer
                {
                    Text = "Dr. Emmett Brown",
                    IsCorrect = true,
                };

                question.Answers.Add(answer);
                answer.Question = question;
                db.Questions.Add(question);
                db.Answers.Add(answer);
                db.SaveChanges();
            }

            using (var db = new TriviaDbContext())
            {
                // Read the data
                Assert.AreEqual(1, db.Questions.Count());
                var question = db.Questions.First();
                Assert.AreEqual("Who invented the time machine?", question.Text);
                Assert.AreEqual(1, question.Answers.Count());
                Assert.AreEqual("Dr. Emmett Brown", question.CorrectAnswer.Text);
            }
        }
    }
}
