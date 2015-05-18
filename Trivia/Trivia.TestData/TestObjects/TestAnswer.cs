using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;

namespace Trivia.TestData.TestObjects
{
    public class TestAnswer : TestObject<Answer>
    {
        private static List<TestAnswer> _TestObjects = new List<TestAnswer>();
        public static IEnumerable<Answer> Entities { get { return _TestObjects.Select(to => to.Entity); } }
        public static IEnumerable<TestAnswer> Values { get { return _TestObjects.AsEnumerable(); } }

        public static readonly TestAnswer ARTIST_OF_THRILLER_CORRECT;
        public static readonly TestAnswer ARTIST_OF_THRILLER_WRONG_1;
        public static readonly TestAnswer ARTIST_OF_THRILLER_WRONG_2;
        public static readonly TestAnswer ARTIST_OF_THRILLER_WRONG_3;

        public static readonly TestAnswer NFL_CAREER_RUSHING_YARDS_CORRECT;
        public static readonly TestAnswer NFL_CAREER_RUSHING_YARDS_WRONG_1;
        public static readonly TestAnswer NFL_CAREER_RUSHING_YARDS_WRONG_2;
        public static readonly TestAnswer NFL_CAREER_RUSHING_YARDS_WRONG_3;

        static TestAnswer()
        {
            ARTIST_OF_THRILLER_CORRECT = new TestAnswer("Michael Jackson", true, TestQuestion.ARTIST_OF_THRILLER);
            ARTIST_OF_THRILLER_WRONG_1 = new TestAnswer("Michael Bolton", false, TestQuestion.ARTIST_OF_THRILLER);
            ARTIST_OF_THRILLER_WRONG_2 = new TestAnswer("Madonna", false, TestQuestion.ARTIST_OF_THRILLER);
            ARTIST_OF_THRILLER_WRONG_3 = new TestAnswer("Barry Manilow", false, TestQuestion.ARTIST_OF_THRILLER);

            NFL_CAREER_RUSHING_YARDS_CORRECT = new TestAnswer("Emmitt Smith", true, TestQuestion.NFL_CAREER_RUSHING_YARDS);
            NFL_CAREER_RUSHING_YARDS_WRONG_1 = new TestAnswer("Walter Payton", false, TestQuestion.NFL_CAREER_RUSHING_YARDS);
            NFL_CAREER_RUSHING_YARDS_WRONG_2 = new TestAnswer("Eric Dickerson", false, TestQuestion.NFL_CAREER_RUSHING_YARDS);
            NFL_CAREER_RUSHING_YARDS_WRONG_3 = new TestAnswer("Barry Sanders", false, TestQuestion.NFL_CAREER_RUSHING_YARDS);
        }

        public TestAnswer(string text, bool isCorrect, TestQuestion testQuestion)
        {
            _TestObjects.Add(this);
            Entity = new Answer
            {
                Text = text,
                IsCorrect = isCorrect,
                Question = testQuestion.Entity,
            };
        }
    }
}
