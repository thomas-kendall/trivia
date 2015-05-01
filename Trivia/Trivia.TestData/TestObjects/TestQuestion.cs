using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;
using Trivia.TestData.TransferObjects;

namespace Trivia.TestData.TestObjects
{
    public class TestQuestion : TestObject<QuestionTO, Question>
    {
        public static readonly TestQuestion ARTIST_OF_THRILLER = new TestQuestion("Who is the artist of the song Thriller?");
        public static readonly TestQuestion NFL_CAREER_RUSHING_YARDS = new TestQuestion("Who holds the NFL record for career rushing yards?");

        public TestQuestion(string text)
        {
            TransferObject = new QuestionTO(this, text);
        }
    }
}
