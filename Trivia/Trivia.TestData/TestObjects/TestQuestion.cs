using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;

namespace Trivia.TestData.TestObjects
{
    public class TestQuestion : TestObject<Question>
    {
        private static List<TestQuestion> _TestObjects = new List<TestQuestion>();
        public static IEnumerable<Question> Entities { get { return _TestObjects.Select(to => to.Entity); } }
        public static IEnumerable<TestQuestion> Values { get { return _TestObjects.AsEnumerable(); } }

        public static readonly TestQuestion ARTIST_OF_THRILLER;
        public static readonly TestQuestion NFL_CAREER_RUSHING_YARDS;

        static TestQuestion()
        {
            ARTIST_OF_THRILLER = new TestQuestion("Who is the artist of the song Thriller?");
            NFL_CAREER_RUSHING_YARDS = new TestQuestion("Who holds the NFL record for career rushing yards?");
        }

        public TestQuestion(string text)
        {
            _TestObjects.Add(this);
            Entity = new Question
            {
                Text = text,
            };
        }
    }
}
