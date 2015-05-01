using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivia.Core.Entities;
using Trivia.Core.Repository;

namespace Trivia.TestData.TransferObjects
{
    public class AnswerTO : TransferObject<Answer>
    {
        private QuestionTO QuestionTO { get; set; }
        private string Text { get; set; }
        private bool IsCorrect { get; set; }

        public AnswerTO(object key, string text, bool isCorrect, QuestionTO questionTO)
        {
            this.Key = key;
            this.Text = text;
            this.IsCorrect = isCorrect;
            this.QuestionTO = questionTO;
        }

        public override Answer Materialize(ITestDataManager testDataManager)
        {
            var entity = (Answer)testDataManager.FindTestObjectByKey(Key);
            if (entity == null)
            {
                entity = new Answer();
                entity.Text = Text;
                entity.IsCorrect = IsCorrect;
                entity.Question = QuestionTO.Materialize(testDataManager);
                testDataManager.AddTestObject(Key, entity);
            }
            return entity;
        }
    }
}
