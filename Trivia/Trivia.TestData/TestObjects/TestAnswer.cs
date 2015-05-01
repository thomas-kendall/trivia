using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;
using Trivia.TestData.TransferObjects;

namespace Trivia.TestData.TestObjects
{
    public class TestAnswer : TestObject<AnswerTO, Answer>
    {
        public static readonly TestAnswer ARTIST_OF_THRILLER_CORRECT = new TestAnswer("Michael Jackson", true, TestQuestion.ARTIST_OF_THRILLER);
        public static readonly TestAnswer ARTIST_OF_THRILLER_WRONG_1 = new TestAnswer("Michael Bolton", false, TestQuestion.ARTIST_OF_THRILLER);
        public static readonly TestAnswer ARTIST_OF_THRILLER_WRONG_2 = new TestAnswer("Madonna", false, TestQuestion.ARTIST_OF_THRILLER);
        public static readonly TestAnswer ARTIST_OF_THRILLER_WRONG_3 = new TestAnswer("Barry Manilow", false, TestQuestion.ARTIST_OF_THRILLER);

        public static readonly TestAnswer NFL_CAREER_RUSHING_YARDS_CORRECT = new TestAnswer("Emmitt Smith", true, TestQuestion.NFL_CAREER_RUSHING_YARDS);
        public static readonly TestAnswer NFL_CAREER_RUSHING_YARDS_WRONG_1 = new TestAnswer("Walter Payton", false, TestQuestion.NFL_CAREER_RUSHING_YARDS);
        public static readonly TestAnswer NFL_CAREER_RUSHING_YARDS_WRONG_2 = new TestAnswer("Eric Dickerson", false, TestQuestion.NFL_CAREER_RUSHING_YARDS);
        public static readonly TestAnswer NFL_CAREER_RUSHING_YARDS_WRONG_3 = new TestAnswer("Barry Sanders", false, TestQuestion.NFL_CAREER_RUSHING_YARDS);

        public TestAnswer(string text, bool isCorrect, TestQuestion testQuestion)
        {               
            TransferObject = new AnswerTO(this, text, isCorrect, testQuestion.TransferObject);
        }
    }
}
